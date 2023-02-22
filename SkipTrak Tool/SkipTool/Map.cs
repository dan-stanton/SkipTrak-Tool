using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;

using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;
using RestSharp.Authenticators.OAuth2;
using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.VisualStyles;

namespace SkipTool
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }
        GMapOverlay skips = new GMapOverlay("skips");
        GMapOverlay vehicles = new GMapOverlay("vehicles");

        private static DataSet ReadDataFromJson(string jsonString, XmlReadMode mode = XmlReadMode.Auto)
        {
            //// Note:Json convertor needs a json with one node as root
            jsonString = $"{{ \"rootNode\": {{{jsonString.Trim().TrimStart('{').TrimEnd('}')}}} }}";
            //// Now it is secure that we have always a Json with one node as root 
            var xd = JsonConvert.DeserializeXmlNode(jsonString);

            //// DataSet is able to read from XML and return a proper DataSet
            var result = new DataSet();
            result.ReadXml(new XmlNodeReader(xd), mode);
            return result;
        }
        private void Map_Load(object sender, EventArgs e)
        {
            if (Form1.driverbox.Checked)
            {
                panel2.Visible = false;
            }
            WindowState = FormWindowState.Maximized;
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            gMapControl1.Position = new PointLatLng(52.039037, -2.673115);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 9;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.Overlays.Add(skips);

            gMapControl1.Overlays.Add(vehicles);
            gMapControl1.ShowCenter = false;

            var client2 = new RestClient("https://api.samsara.com/v1/fleet/drivers");

            client2.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                "REDACTED TOKEN", "Bearer"
            );

            var request2 = new RestRequest();
            //request2.AddParameter("id", driverid);

            var response2 = client2.Get(request2);

            Debug.Write(response2.Content);


            var dataset2 = ReadDataFromJson(response2.Content, XmlReadMode.InferTypedSchema);
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dataset2; // dataset
            dataGridView2.DataMember = "drivers"; // table name you need to show

        }

        private void LoadThings()
        {
            GMarkerGoogle temp;
            GeoCoderStatusCode status;
            Thread.Sleep(500);
            LoadVehicles();



            GMarkerGoogleType marker = GMarkerGoogleType.yellow_pushpin;
            foreach (DataGridViewRow row in Form1.skipGridView.Rows)
            {

                if (!String.IsNullOrEmpty(row.Cells["s_postcode"].Value as String) && !String.IsNullOrEmpty(row.Cells["s_address_1"].Value as String))
                {
                    var postcode = row.Cells["s_postcode"].Value.ToString();
                    var address1 = row.Cells["s_address_1"].Value.ToString();

                    if (!String.IsNullOrEmpty(postcode))
                    {
                        var pos = gMapControl1.GeocodingProvider.GetPoint(postcode, out status);
                        if (pos != null && status == GeoCoderStatusCode.OK)
                        {
                            temp = new GMarkerGoogle(pos.Value, marker);

                            var tooltextstr = "ID: " + row.Cells["id"].Value as String;
                            tooltextstr += "\nDate: " + row.Cells["start"].Value as String;

                            if (!String.IsNullOrEmpty(row.Cells["surname"].Value as String)) tooltextstr += "\nSurname: " + row.Cells["surname"].Value as String;
                            if (!String.IsNullOrEmpty(row.Cells["forenames"].Value as String)) tooltextstr += "\nForename: " + row.Cells["forenames"].Value as String;
                            if (!String.IsNullOrEmpty(row.Cells["skip_type"].Value as String)) tooltextstr += "\nSkip Type: " + row.Cells["skip_type"].Value as String;
                            temp.ToolTipText = tooltextstr;
                            var toolTip1 = new GMapToolTip(temp);
                            toolTip1.Fill = new SolidBrush(Color.Gray);
                            skips.Markers.Add(temp);
                            Debug.WriteLine("Done" + row.Cells["id"].Value);
                        }
                        else
                        {
                            Debug.WriteLine("GeoCoderStatusCode = " + status.ToString());
                        }

                    }
                }
            }
            panel1.Visible = false;
        }
        private void Map_Shown_1(object sender, EventArgs e)
        {
            LoadThings();
            
        }
        int timercounter = 0;
        int tickdown = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tickdown == 0) tickdown = 60;
            else tickdown--;

            label3.Text = "Next update in: " + tickdown.ToString();

            timercounter++;
            label1.Text = "Loading... ";
        }

        private void LoadVehicles()
        {
            string labeltext = "";
            var client = new RestClient("https://api.samsara.com/v1/fleet/locations");

            client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                "REDACTED TOKEN", "Bearer"
            );

            var request = new RestRequest();
            request.AddParameter("vehicleIds", "212014918917093,212014918916966,281474980802073,281474979526169,212014918917146,212014918916757,212014918916785,212014918917071,281474978787848, 212014918917132");

            var response = client.Get(request);


            var dataset = ReadDataFromJson(response.Content, XmlReadMode.InferTypedSchema);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataset; // dataset
            dataGridView1.DataMember = "Vehicles"; // table name you need to show


            GMarkerGoogle temp;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var driverid = "Unknown";
                foreach (DataGridViewRow row2 in dataGridView2.Rows)
                {
                    if (row.Cells["driverId"].Value.ToString() == row2.Cells["id"].Value.ToString())
                    {
                        driverid = row2.Cells["name"].Value as String;
                        break;
                    }
                }


                GMarkerGoogleType marker_veh = GMarkerGoogleType.red_dot;

                double lat = Convert.ToDouble(row.Cells["latitude"].Value);
                double lng = Convert.ToDouble(row.Cells["longitude"].Value);

                temp = new GMarkerGoogle(new PointLatLng(lat, lng), marker_veh);

                var tooltextstr = row.Cells["name"].Value as String;
                temp.ToolTipText = tooltextstr;
                temp.ToolTipMode = MarkerTooltipMode.Always;
                var toolTip1 = new GMapToolTip(temp);
                toolTip1.Fill = new SolidBrush(Color.Gray);

                labeltext += row.Cells["name"].Value as String + " - " +driverid+ " - " + row.Cells["location"].Value as String + "\n";
                vehicles.Markers.Add(temp);
                Debug.WriteLine("Done" + row.Cells["id"].Value);
                Thread.Sleep(100);
            }
            label2.Text = labeltext;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            vehicles.Markers.Clear();
            skips.Markers.Clear();
            Form1.button2.PerformClick();//simulate search button
            LoadThings();

        }
    }
}

using Advantage.Data.Provider;
using System.ComponentModel;
using System.Data;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SkipTool
{
    public partial class Form1 : Form
    {
        AdsConnection myConnection = new AdsConnection(@"REDACTED DATASOURCE");
        string loadcolumns = "id, start, surname, forenames, s_address_1, s_address_2, s_address_3, s_address_4, s_address_5, s_postcode, phone, mobile, direction, skip_type";
        string query = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loading.Visible = false;
            myConnection.Open();
            string query = "SELECT name FROM skiptypes";
            AdsCommand command = new AdsCommand(query, myConnection);
            AdsDataReader sqlReader = command.ExecuteReader();

            while (sqlReader.Read())
            {
                comboBox1.Items.Add(sqlReader["Name"].ToString());
            }
            sqlReader.Close();
            myConnection.Close();
        }

        private void loadmap_Click(object sender, EventArgs e)
        {
            using (Map form = new Map())
            {
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string concatstring = "(LOWER(surname) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(forenames) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(address_1) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(address_2) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(address_3) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(address_4) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(address_5) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(postcode) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(phone) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(mobile) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(email) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_address_1) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_address_2) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_address_3) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_address_4) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_address_5) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_postcode) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_phone) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_mobile) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_contact) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(s_email) LIKE LOWER('%" + textBox1.Text + "%')) OR (LOWER(custorder) LIKE LOWER('%" + textBox1.Text + "%'))";
            DateTime localDate = DateTime.Now;

            query = "SELECT " + loadcolumns + " FROM  job s WHERE 1=1";
            if (datedtoday.Checked) query += " AND (JOB_DATE BETWEEN '"+localDate.ToString("MM/dd/yyyy") + "' AND '"+localDate.ToString("MM/dd/yyyy") +"')";
            if (outstanding.Checked) query += " AND (RET_YN = 'N') AND (DEL_COLL <> 'C')";
            if (onroad.Checked) query += " AND (location = 'On Road')";
            if (comboBox1.Text != "") query += " AND (skip_type = '" + comboBox1.Text + "')";
            if (!String.IsNullOrEmpty(textBox1.Text)) query += " AND (" + concatstring + ")";

            query += ";";
            StartLoading();
        }

        public async void StartLoading()
        {
            loading.Visible = true;
            await Task.Run(() => LoadGrid());
            int i = 0;
            foreach (DataGridViewRow row in skipGridView.Rows)
            {
                i++;
            }
            results.Text = i.ToString();

            myConnection.Close();
            loadmap.Enabled = true;
            loading.Visible = false;
        }

        public async void LoadGrid()
        {

            AdsCommand command = new AdsCommand(query, myConnection);
            DataTable table;
            AdsDataAdapter adapter = new AdsDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            skipGridView.Invoke(new Action(() => { skipGridView.DataSource = table; }));



        }

        private void datedtoday_CheckedChanged(object sender, EventArgs e)
        {
            if (datedtoday.Checked)
            {
                onroad.Checked = false;
                onroad.Enabled = false;
                outstanding.Checked = false;
                outstanding.Enabled = false;
                textBox1.Enabled = false;
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox1.Enabled = false;
            }
            else
            {
                onroad.Checked = false;
                onroad.Enabled = true;
                outstanding.Checked = false;
                outstanding.Enabled = true;
                textBox1.Enabled = true;
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }
        }
    }
}
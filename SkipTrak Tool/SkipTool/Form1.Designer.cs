namespace SkipTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new System.Windows.Forms.Button();
            this.outstanding = new System.Windows.Forms.CheckBox();
            this.onroad = new System.Windows.Forms.CheckBox();
            this.loadmap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            skipGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            driverbox = new System.Windows.Forms.CheckBox();
            this.datedtoday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(skipGridView)).BeginInit();
            this.loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            button2.Location = new System.Drawing.Point(713, 367);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // outstanding
            // 
            this.outstanding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outstanding.AutoSize = true;
            this.outstanding.Location = new System.Drawing.Point(12, 380);
            this.outstanding.Name = "outstanding";
            this.outstanding.Size = new System.Drawing.Size(178, 19);
            this.outstanding.TabIndex = 9;
            this.outstanding.Text = "Only show outstanding skips";
            this.outstanding.UseVisualStyleBackColor = true;
            // 
            // onroad
            // 
            this.onroad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onroad.AutoSize = true;
            this.onroad.Location = new System.Drawing.Point(12, 355);
            this.onroad.Name = "onroad";
            this.onroad.Size = new System.Drawing.Size(155, 19);
            this.onroad.TabIndex = 8;
            this.onroad.Text = "Only show skips on road";
            this.onroad.UseVisualStyleBackColor = true;
            // 
            // loadmap
            // 
            this.loadmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadmap.Enabled = false;
            this.loadmap.Location = new System.Drawing.Point(713, 405);
            this.loadmap.Name = "loadmap";
            this.loadmap.Size = new System.Drawing.Size(75, 23);
            this.loadmap.TabIndex = 11;
            this.loadmap.Text = "Load Map";
            this.loadmap.UseVisualStyleBackColor = true;
            this.loadmap.Click += new System.EventHandler(this.loadmap_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Options";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Skip Type";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(394, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search by: Phone, Email, Address, PO etc...";
            // 
            // skipGridView
            // 
            skipGridView.AllowUserToAddRows = false;
            skipGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            skipGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            skipGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            skipGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            skipGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            skipGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            skipGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            skipGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            skipGridView.DefaultCellStyle = dataGridViewCellStyle3;
            skipGridView.Location = new System.Drawing.Point(2, 2);
            skipGridView.Name = "skipGridView";
            skipGridView.ReadOnly = true;
            skipGridView.RowHeadersVisible = false;
            skipGridView.RowTemplate.Height = 25;
            skipGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            skipGridView.Size = new System.Drawing.Size(797, 321);
            skipGridView.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Results: ";
            // 
            // results
            // 
            this.results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(757, 327);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(13, 15);
            this.results.TabIndex = 20;
            this.results.Text = "0";
            // 
            // loading
            // 
            this.loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loading.Controls.Add(this.label3);
            this.loading.Location = new System.Drawing.Point(288, 116);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(200, 100);
            this.loading.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loading...";
            // 
            // driverbox
            // 
            driverbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            driverbox.AutoSize = true;
            driverbox.Location = new System.Drawing.Point(12, 405);
            driverbox.Name = "driverbox";
            driverbox.Size = new System.Drawing.Size(151, 19);
            driverbox.TabIndex = 22;
            driverbox.Text = "Hide driver box on map";
            driverbox.UseVisualStyleBackColor = true;
            // 
            // datedtoday
            // 
            this.datedtoday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datedtoday.AutoSize = true;
            this.datedtoday.Location = new System.Drawing.Point(178, 405);
            this.datedtoday.Name = "datedtoday";
            this.datedtoday.Size = new System.Drawing.Size(173, 19);
            this.datedtoday.TabIndex = 23;
            this.datedtoday.Text = "Only show jobs dated today";
            this.datedtoday.UseVisualStyleBackColor = true;
            this.datedtoday.CheckedChanged += new System.EventHandler(this.datedtoday_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datedtoday);
            this.Controls.Add(driverbox);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label5);
            this.Controls.Add(skipGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outstanding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onroad);
            this.Controls.Add(this.loadmap);
            this.Controls.Add(button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SkipTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(skipGridView)).EndInit();
            this.loading.ResumeLayout(false);
            this.loading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox outstanding;
        private CheckBox onroad;
        private Button loadmap;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        public Label results;
        private Panel loading;
        private Label label3;
        private CheckBox datedtoday;
        public static Button button2;
        public static DataGridView skipGridView;
        public static CheckBox driverbox;
    }
}
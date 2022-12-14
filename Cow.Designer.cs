namespace ZadanieSOFI
{
    partial class Cow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EarNumberCow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfCalfs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapabilityHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IDLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarNumberLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EarNumberCow,
            this.NumberOfCalfs});
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(291, 512);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // EarNumberCow
            // 
            this.EarNumberCow.DataPropertyName = "USNE_CISLO";
            this.EarNumberCow.HeaderText = "Ear number";
            this.EarNumberCow.MinimumWidth = 6;
            this.EarNumberCow.Name = "EarNumberCow";
            this.EarNumberCow.ReadOnly = true;
            this.EarNumberCow.Width = 125;
            // 
            // NumberOfCalfs
            // 
            this.NumberOfCalfs.DataPropertyName = "POCET_TELAT";
            this.NumberOfCalfs.HeaderText = "Column2";
            this.NumberOfCalfs.MinimumWidth = 6;
            this.NumberOfCalfs.Name = "NumberOfCalfs";
            this.NumberOfCalfs.ReadOnly = true;
            this.NumberOfCalfs.Visible = false;
            this.NumberOfCalfs.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(312, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(788, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pocet teliat";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(400, 151);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(240, 26);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(400, 116);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 26);
            this.textBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(295, 261);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Vyradena";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celkovy nadojeny objem mlieka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cislo aktualnej laktacie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cislo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(788, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Health info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(457, 306);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(324, 112);
            this.textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(457, 86);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(324, 112);
            this.textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(457, 51);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(324, 26);
            this.textBox3.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(324, 26);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(351, 269);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Vyradena";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dovod vyradenia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Poznamka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Zdravotny stav";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datum vytvorenia";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHealthInfo,
            this.DateHealthInfo,
            this.NoteHealthInfo,
            this.StateHealthInfo,
            this.CapabilityHealthInfo,
            this.EarNumber});
            this.dataGridView2.Location = new System.Drawing.Point(7, 8);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(280, 425);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // IDHealthInfo
            // 
            this.IDHealthInfo.DataPropertyName = "ID";
            this.IDHealthInfo.HeaderText = "ID";
            this.IDHealthInfo.MinimumWidth = 6;
            this.IDHealthInfo.Name = "IDHealthInfo";
            this.IDHealthInfo.ReadOnly = true;
            this.IDHealthInfo.Visible = false;
            this.IDHealthInfo.Width = 125;
            // 
            // DateHealthInfo
            // 
            this.DateHealthInfo.DataPropertyName = "DATUM";
            this.DateHealthInfo.HeaderText = "Zdravotny zaznam";
            this.DateHealthInfo.MinimumWidth = 6;
            this.DateHealthInfo.Name = "DateHealthInfo";
            this.DateHealthInfo.ReadOnly = true;
            this.DateHealthInfo.Width = 125;
            // 
            // NoteHealthInfo
            // 
            this.NoteHealthInfo.DataPropertyName = "POZNAMKA";
            this.NoteHealthInfo.HeaderText = "Poznamka";
            this.NoteHealthInfo.MinimumWidth = 6;
            this.NoteHealthInfo.Name = "NoteHealthInfo";
            this.NoteHealthInfo.ReadOnly = true;
            this.NoteHealthInfo.Visible = false;
            this.NoteHealthInfo.Width = 125;
            // 
            // StateHealthInfo
            // 
            this.StateHealthInfo.DataPropertyName = "ZDRAVOTNY_STAV";
            this.StateHealthInfo.HeaderText = "Zdravotny stav";
            this.StateHealthInfo.MinimumWidth = 6;
            this.StateHealthInfo.Name = "StateHealthInfo";
            this.StateHealthInfo.ReadOnly = true;
            this.StateHealthInfo.Visible = false;
            this.StateHealthInfo.Width = 125;
            // 
            // CapabilityHealthInfo
            // 
            this.CapabilityHealthInfo.DataPropertyName = "ZDRAVOTNA_SPOSOBILOST";
            this.CapabilityHealthInfo.HeaderText = "Zdravotna sposobilost";
            this.CapabilityHealthInfo.MinimumWidth = 6;
            this.CapabilityHealthInfo.Name = "CapabilityHealthInfo";
            this.CapabilityHealthInfo.ReadOnly = true;
            this.CapabilityHealthInfo.Visible = false;
            this.CapabilityHealthInfo.Width = 125;
            // 
            // EarNumber
            // 
            this.EarNumber.DataPropertyName = "USNE_CISLO";
            this.EarNumber.HeaderText = "Usne cislo";
            this.EarNumber.MinimumWidth = 6;
            this.EarNumber.Name = "EarNumber";
            this.EarNumber.ReadOnly = true;
            this.EarNumber.Visible = false;
            this.EarNumber.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(788, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lactation info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(474, 69);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(307, 26);
            this.textBox8.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(474, 104);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(474, 174);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(307, 109);
            this.textBox7.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(474, 139);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(307, 26);
            this.textBox6.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Poznamky";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nadojeny objem mlieka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Datum zacatia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cislo laktacie";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLactationInfo,
            this.NumLactationInfo,
            this.NoteLactationInfo,
            this.DateLactationInfo,
            this.VolumeLactationInfo,
            this.EarNumberLactationInfo});
            this.dataGridView3.Location = new System.Drawing.Point(7, 8);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(280, 425);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView3_RowStateChanged);
            // 
            // IDLactationInfo
            // 
            this.IDLactationInfo.DataPropertyName = "ID";
            this.IDLactationInfo.HeaderText = "ID";
            this.IDLactationInfo.MinimumWidth = 6;
            this.IDLactationInfo.Name = "IDLactationInfo";
            this.IDLactationInfo.ReadOnly = true;
            this.IDLactationInfo.Visible = false;
            this.IDLactationInfo.Width = 125;
            // 
            // NumLactationInfo
            // 
            this.NumLactationInfo.DataPropertyName = "CISLO_LAKTACIE";
            this.NumLactationInfo.HeaderText = "Laktacny zaznam";
            this.NumLactationInfo.MinimumWidth = 6;
            this.NumLactationInfo.Name = "NumLactationInfo";
            this.NumLactationInfo.ReadOnly = true;
            this.NumLactationInfo.Width = 125;
            // 
            // NoteLactationInfo
            // 
            this.NoteLactationInfo.DataPropertyName = "POZNAMKA";
            this.NoteLactationInfo.HeaderText = "Poznamka";
            this.NoteLactationInfo.MinimumWidth = 6;
            this.NoteLactationInfo.Name = "NoteLactationInfo";
            this.NoteLactationInfo.ReadOnly = true;
            this.NoteLactationInfo.Visible = false;
            this.NoteLactationInfo.Width = 125;
            // 
            // DateLactationInfo
            // 
            this.DateLactationInfo.DataPropertyName = "DATUM";
            this.DateLactationInfo.HeaderText = "Datum";
            this.DateLactationInfo.MinimumWidth = 6;
            this.DateLactationInfo.Name = "DateLactationInfo";
            this.DateLactationInfo.ReadOnly = true;
            this.DateLactationInfo.Visible = false;
            this.DateLactationInfo.Width = 125;
            // 
            // VolumeLactationInfo
            // 
            this.VolumeLactationInfo.DataPropertyName = "OBJEM_MLIEKA";
            this.VolumeLactationInfo.HeaderText = "Objem nadojeneho mlieka";
            this.VolumeLactationInfo.MinimumWidth = 6;
            this.VolumeLactationInfo.Name = "VolumeLactationInfo";
            this.VolumeLactationInfo.ReadOnly = true;
            this.VolumeLactationInfo.Visible = false;
            this.VolumeLactationInfo.Width = 125;
            // 
            // EarNumberLactationInfo
            // 
            this.EarNumberLactationInfo.DataPropertyName = "USNE_CISLO";
            this.EarNumberLactationInfo.HeaderText = "Usne cislo";
            this.EarNumberLactationInfo.MinimumWidth = 6;
            this.EarNumberLactationInfo.Name = "EarNumberLactationInfo";
            this.EarNumberLactationInfo.ReadOnly = true;
            this.EarNumberLactationInfo.Visible = false;
            this.EarNumberLactationInfo.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(688, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 34);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Cow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cow";
            this.Text = "Cow";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberCow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCalfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapabilityHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberLactationInfo;
    }
}
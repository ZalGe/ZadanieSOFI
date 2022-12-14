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
            this.label_val_state = new System.Windows.Forms.Label();
            this.label_actualState = new System.Windows.Forms.Label();
            this.label_val_lac = new System.Windows.Forms.Label();
            this.label_val_volume = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_clafNum = new System.Windows.Forms.NumericUpDown();
            this.textBox_earNum = new System.Windows.Forms.TextBox();
            this.label_totalVol = new System.Windows.Forms.Label();
            this.label_activeLac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_healthNote = new System.Windows.Forms.TextBox();
            this.textBox_healthState = new System.Windows.Forms.TextBox();
            this.dateTimePicker_healthDate = new System.Windows.Forms.DateTimePicker();
            this.checkBox_outOrder = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_lacNum = new System.Windows.Forms.TextBox();
            this.dateTimePicker_lacDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_lacNote = new System.Windows.Forms.TextBox();
            this.textBox_lacVolume = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.IDHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapabilityHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarNumberHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clafNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(311, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_val_state);
            this.tabPage1.Controls.Add(this.label_actualState);
            this.tabPage1.Controls.Add(this.label_val_lac);
            this.tabPage1.Controls.Add(this.label_val_volume);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numericUpDown_clafNum);
            this.tabPage1.Controls.Add(this.textBox_earNum);
            this.tabPage1.Controls.Add(this.label_totalVol);
            this.tabPage1.Controls.Add(this.label_activeLac);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(801, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Základné informácie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_val_state
            // 
            this.label_val_state.AutoSize = true;
            this.label_val_state.Location = new System.Drawing.Point(402, 290);
            this.label_val_state.Name = "label_val_state";
            this.label_val_state.Size = new System.Drawing.Size(59, 20);
            this.label_val_state.TabIndex = 13;
            this.label_val_state.Text = "aktívna";
            // 
            // label_actualState
            // 
            this.label_actualState.AutoSize = true;
            this.label_actualState.Location = new System.Drawing.Point(288, 290);
            this.label_actualState.Name = "label_actualState";
            this.label_actualState.Size = new System.Drawing.Size(107, 20);
            this.label_actualState.TabIndex = 12;
            this.label_actualState.Text = "Aktuálny stav:";
            // 
            // label_val_lac
            // 
            this.label_val_lac.AutoSize = true;
            this.label_val_lac.Location = new System.Drawing.Point(402, 217);
            this.label_val_lac.Name = "label_val_lac";
            this.label_val_lac.Size = new System.Drawing.Size(18, 20);
            this.label_val_lac.TabIndex = 11;
            this.label_val_lac.Text = "6";
            // 
            // label_val_volume
            // 
            this.label_val_volume.AutoSize = true;
            this.label_val_volume.Location = new System.Drawing.Point(402, 253);
            this.label_val_volume.Name = "label_val_volume";
            this.label_val_volume.Size = new System.Drawing.Size(71, 20);
            this.label_val_volume.TabIndex = 10;
            this.label_val_volume.Text = "69 000 L";
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
            // numericUpDown_clafNum
            // 
            this.numericUpDown_clafNum.Location = new System.Drawing.Point(400, 116);
            this.numericUpDown_clafNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_clafNum.Name = "numericUpDown_clafNum";
            this.numericUpDown_clafNum.Size = new System.Drawing.Size(240, 26);
            this.numericUpDown_clafNum.TabIndex = 7;
            // 
            // textBox_earNum
            // 
            this.textBox_earNum.Location = new System.Drawing.Point(400, 81);
            this.textBox_earNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_earNum.Name = "textBox_earNum";
            this.textBox_earNum.Size = new System.Drawing.Size(239, 26);
            this.textBox_earNum.TabIndex = 5;
            // 
            // label_totalVol
            // 
            this.label_totalVol.AutoSize = true;
            this.label_totalVol.Location = new System.Drawing.Point(169, 253);
            this.label_totalVol.Name = "label_totalVol";
            this.label_totalVol.Size = new System.Drawing.Size(231, 20);
            this.label_totalVol.TabIndex = 3;
            this.label_totalVol.Text = "Celkový nadojený objem mlieka:";
            // 
            // label_activeLac
            // 
            this.label_activeLac.AutoSize = true;
            this.label_activeLac.Location = new System.Drawing.Point(231, 217);
            this.label_activeLac.Name = "label_activeLac";
            this.label_activeLac.Size = new System.Drawing.Size(173, 20);
            this.label_activeLac.TabIndex = 1;
            this.label_activeLac.Text = "Číslo aktuálnej laktácie:";
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
            this.tabPage2.Controls.Add(this.textBox_healthNote);
            this.tabPage2.Controls.Add(this.textBox_healthState);
            this.tabPage2.Controls.Add(this.dateTimePicker_healthDate);
            this.tabPage2.Controls.Add(this.checkBox_outOrder);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(801, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zdravotné informácie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_healthNote
            // 
            this.textBox_healthNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_healthNote.Location = new System.Drawing.Point(457, 237);
            this.textBox_healthNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_healthNote.Multiline = true;
            this.textBox_healthNote.Name = "textBox_healthNote";
            this.textBox_healthNote.Size = new System.Drawing.Size(324, 112);
            this.textBox_healthNote.TabIndex = 18;
            // 
            // textBox_healthState
            // 
            this.textBox_healthState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_healthState.Location = new System.Drawing.Point(457, 110);
            this.textBox_healthState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_healthState.Multiline = true;
            this.textBox_healthState.Name = "textBox_healthState";
            this.textBox_healthState.Size = new System.Drawing.Size(324, 95);
            this.textBox_healthState.TabIndex = 17;
            // 
            // dateTimePicker_healthDate
            // 
            this.dateTimePicker_healthDate.Location = new System.Drawing.Point(457, 45);
            this.dateTimePicker_healthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_healthDate.Name = "dateTimePicker_healthDate";
            this.dateTimePicker_healthDate.Size = new System.Drawing.Size(324, 26);
            this.dateTimePicker_healthDate.TabIndex = 16;
            // 
            // checkBox_outOrder
            // 
            this.checkBox_outOrder.AutoSize = true;
            this.checkBox_outOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_outOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_outOrder.Location = new System.Drawing.Point(565, 381);
            this.checkBox_outOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_outOrder.Name = "checkBox_outOrder";
            this.checkBox_outOrder.Size = new System.Drawing.Size(118, 26);
            this.checkBox_outOrder.TabIndex = 15;
            this.checkBox_outOrder.Text = "Vyradená:";
            this.checkBox_outOrder.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(352, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Poznámka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(317, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Zdravotný stav:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(296, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dátum vytvorenia:";
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
            this.EarNumberHealth});
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_lacNum);
            this.tabPage3.Controls.Add(this.dateTimePicker_lacDate);
            this.tabPage3.Controls.Add(this.textBox_lacNote);
            this.tabPage3.Controls.Add(this.textBox_lacVolume);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(801, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informácie o laktáciach";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_lacNum
            // 
            this.textBox_lacNum.Location = new System.Drawing.Point(474, 69);
            this.textBox_lacNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_lacNum.Name = "textBox_lacNum";
            this.textBox_lacNum.Size = new System.Drawing.Size(307, 26);
            this.textBox_lacNum.TabIndex = 22;
            // 
            // dateTimePicker_lacDate
            // 
            this.dateTimePicker_lacDate.Location = new System.Drawing.Point(474, 104);
            this.dateTimePicker_lacDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_lacDate.Name = "dateTimePicker_lacDate";
            this.dateTimePicker_lacDate.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker_lacDate.TabIndex = 21;
            // 
            // textBox_lacNote
            // 
            this.textBox_lacNote.Location = new System.Drawing.Point(474, 174);
            this.textBox_lacNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_lacNote.Multiline = true;
            this.textBox_lacNote.Name = "textBox_lacNote";
            this.textBox_lacNote.Size = new System.Drawing.Size(307, 109);
            this.textBox_lacNote.TabIndex = 20;
            // 
            // textBox_lacVolume
            // 
            this.textBox_lacVolume.Location = new System.Drawing.Point(474, 139);
            this.textBox_lacVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_lacVolume.Name = "textBox_lacVolume";
            this.textBox_lacVolume.Size = new System.Drawing.Size(307, 26);
            this.textBox_lacVolume.TabIndex = 19;
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
            this.panel1.Location = new System.Drawing.Point(702, 495);
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
            this.button1.Text = "Nový";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Upraviť";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Odstrániť";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Zavrieť ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(477, 495);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 34);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Uložiť";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 3);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Zrušiť";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.DateHealthInfo.HeaderText = "Zdravotný záznam";
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
            // EarNumberHealth
            // 
            this.EarNumberHealth.DataPropertyName = "USNE_CISLO";
            this.EarNumberHealth.HeaderText = "Usne cislo";
            this.EarNumberHealth.MinimumWidth = 6;
            this.EarNumberHealth.Name = "EarNumberHealth";
            this.EarNumberHealth.ReadOnly = true;
            this.EarNumberHealth.Visible = false;
            this.EarNumberHealth.Width = 125;
            // 
            // Cow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clafNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label_totalVol;
        private System.Windows.Forms.Label label_activeLac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_outOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_clafNum;
        private System.Windows.Forms.TextBox textBox_earNum;
        private System.Windows.Forms.TextBox textBox_healthNote;
        private System.Windows.Forms.TextBox textBox_healthState;
        private System.Windows.Forms.DateTimePicker dateTimePicker_healthDate;
        private System.Windows.Forms.TextBox textBox_lacNum;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lacDate;
        private System.Windows.Forms.TextBox textBox_lacNote;
        private System.Windows.Forms.TextBox textBox_lacVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberCow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCalfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberLactationInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label_val_state;
        private System.Windows.Forms.Label label_actualState;
        private System.Windows.Forms.Label label_val_lac;
        private System.Windows.Forms.Label label_val_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapabilityHealthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberHealth;
    }
}
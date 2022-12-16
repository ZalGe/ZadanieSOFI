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
            this.dataGridView_Cow = new System.Windows.Forms.DataGridView();
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
            this.dataGridView_Health = new System.Windows.Forms.DataGridView();
            this.IDHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapabilityHealthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarNumberHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDown_lacNum = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_LacDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_LacNote = new System.Windows.Forms.TextBox();
            this.textBox_LacVolume = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_Lactation = new System.Windows.Forms.DataGridView();
            this.IDLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarNumberLactationInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Discard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cow)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clafNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Health)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lactation)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Cow
            // 
            this.dataGridView_Cow.AllowUserToAddRows = false;
            this.dataGridView_Cow.AllowUserToDeleteRows = false;
            this.dataGridView_Cow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Cow.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Cow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EarNumberCow,
            this.NumberOfCalfs});
            this.dataGridView_Cow.Location = new System.Drawing.Point(14, 15);
            this.dataGridView_Cow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Cow.MultiSelect = false;
            this.dataGridView_Cow.Name = "dataGridView_Cow";
            this.dataGridView_Cow.ReadOnly = true;
            this.dataGridView_Cow.RowHeadersWidth = 51;
            this.dataGridView_Cow.RowTemplate.Height = 24;
            this.dataGridView_Cow.Size = new System.Drawing.Size(291, 587);
            this.dataGridView_Cow.TabIndex = 0;
            this.dataGridView_Cow.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView_Cow_RowStateChanged);
            // 
            // EarNumberCow
            // 
            this.EarNumberCow.DataPropertyName = "USNE_CISLO";
            this.EarNumberCow.HeaderText = "Ušné číslo kravy";
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
            this.tabControl1.Size = new System.Drawing.Size(809, 551);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
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
            this.tabPage1.Size = new System.Drawing.Size(801, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Základné informácie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_val_state
            // 
            this.label_val_state.AutoSize = true;
            this.label_val_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_val_state.Location = new System.Drawing.Point(396, 379);
            this.label_val_state.Name = "label_val_state";
            this.label_val_state.Size = new System.Drawing.Size(67, 22);
            this.label_val_state.TabIndex = 13;
            this.label_val_state.Text = "aktívna";
            // 
            // label_actualState
            // 
            this.label_actualState.AutoSize = true;
            this.label_actualState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_actualState.Location = new System.Drawing.Point(266, 379);
            this.label_actualState.Name = "label_actualState";
            this.label_actualState.Size = new System.Drawing.Size(122, 22);
            this.label_actualState.TabIndex = 12;
            this.label_actualState.Text = "Aktuálny stav:";
            // 
            // label_val_lac
            // 
            this.label_val_lac.AutoSize = true;
            this.label_val_lac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_val_lac.Location = new System.Drawing.Point(396, 264);
            this.label_val_lac.Name = "label_val_lac";
            this.label_val_lac.Size = new System.Drawing.Size(20, 22);
            this.label_val_lac.TabIndex = 11;
            this.label_val_lac.Text = "6";
            // 
            // label_val_volume
            // 
            this.label_val_volume.AutoSize = true;
            this.label_val_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_val_volume.Location = new System.Drawing.Point(396, 319);
            this.label_val_volume.Name = "label_val_volume";
            this.label_val_volume.Size = new System.Drawing.Size(80, 22);
            this.label_val_volume.TabIndex = 10;
            this.label_val_volume.Text = "69 000 L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(288, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Počet teliat:";
            // 
            // numericUpDown_clafNum
            // 
            this.numericUpDown_clafNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_clafNum.Location = new System.Drawing.Point(400, 137);
            this.numericUpDown_clafNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_clafNum.Name = "numericUpDown_clafNum";
            this.numericUpDown_clafNum.Size = new System.Drawing.Size(239, 26);
            this.numericUpDown_clafNum.TabIndex = 7;
            // 
            // textBox_earNum
            // 
            this.textBox_earNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_earNum.Location = new System.Drawing.Point(400, 88);
            this.textBox_earNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_earNum.Name = "textBox_earNum";
            this.textBox_earNum.Size = new System.Drawing.Size(239, 26);
            this.textBox_earNum.TabIndex = 5;
            // 
            // label_totalVol
            // 
            this.label_totalVol.AutoSize = true;
            this.label_totalVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalVol.Location = new System.Drawing.Point(95, 319);
            this.label_totalVol.Name = "label_totalVol";
            this.label_totalVol.Size = new System.Drawing.Size(293, 22);
            this.label_totalVol.TabIndex = 3;
            this.label_totalVol.Text = "Celkový nadojený objem mlieka (L):";
            // 
            // label_activeLac
            // 
            this.label_activeLac.AutoSize = true;
            this.label_activeLac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_activeLac.Location = new System.Drawing.Point(190, 264);
            this.label_activeLac.Name = "label_activeLac";
            this.label_activeLac.Size = new System.Drawing.Size(198, 22);
            this.label_activeLac.TabIndex = 1;
            this.label_activeLac.Text = "Číslo aktuálnej laktácie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(333, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Číslo:";
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
            this.tabPage2.Controls.Add(this.dataGridView_Health);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(801, 518);
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
            // dataGridView_Health
            // 
            this.dataGridView_Health.AllowUserToAddRows = false;
            this.dataGridView_Health.AllowUserToDeleteRows = false;
            this.dataGridView_Health.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Health.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Health.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Health.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHealthInfo,
            this.DateHealthInfo,
            this.NoteHealthInfo,
            this.StateHealthInfo,
            this.CapabilityHealthInfo,
            this.EarNumberHealth});
            this.dataGridView_Health.Location = new System.Drawing.Point(7, 8);
            this.dataGridView_Health.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Health.Name = "dataGridView_Health";
            this.dataGridView_Health.ReadOnly = true;
            this.dataGridView_Health.RowHeadersWidth = 51;
            this.dataGridView_Health.RowTemplate.Height = 24;
            this.dataGridView_Health.Size = new System.Drawing.Size(280, 500);
            this.dataGridView_Health.TabIndex = 4;
            this.dataGridView_Health.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView_Health_RowStateChanged);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numericUpDown_lacNum);
            this.tabPage3.Controls.Add(this.dateTimePicker_LacDate);
            this.tabPage3.Controls.Add(this.textBox_LacNote);
            this.tabPage3.Controls.Add(this.textBox_LacVolume);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dataGridView_Lactation);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(801, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informácie o laktáciach";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_lacNum
            // 
            this.numericUpDown_lacNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_lacNum.Location = new System.Drawing.Point(676, 125);
            this.numericUpDown_lacNum.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_lacNum.Name = "numericUpDown_lacNum";
            this.numericUpDown_lacNum.Size = new System.Drawing.Size(105, 26);
            this.numericUpDown_lacNum.TabIndex = 22;
            // 
            // dateTimePicker_LacDate
            // 
            this.dateTimePicker_LacDate.Location = new System.Drawing.Point(474, 48);
            this.dateTimePicker_LacDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_LacDate.Name = "dateTimePicker_LacDate";
            this.dateTimePicker_LacDate.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker_LacDate.TabIndex = 21;
            // 
            // textBox_LacNote
            // 
            this.textBox_LacNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LacNote.Location = new System.Drawing.Point(474, 281);
            this.textBox_LacNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_LacNote.Multiline = true;
            this.textBox_LacNote.Name = "textBox_LacNote";
            this.textBox_LacNote.Size = new System.Drawing.Size(307, 109);
            this.textBox_LacNote.TabIndex = 20;
            // 
            // textBox_LacVolume
            // 
            this.textBox_LacVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_LacVolume.Location = new System.Drawing.Point(676, 202);
            this.textBox_LacVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_LacVolume.Name = "textBox_LacVolume";
            this.textBox_LacVolume.Size = new System.Drawing.Size(105, 26);
            this.textBox_LacVolume.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(362, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "Poznámky:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(470, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nadojený objem mlieka:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(331, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Dátum začatia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(538, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Číslo laktácie:";
            // 
            // dataGridView_Lactation
            // 
            this.dataGridView_Lactation.AllowUserToAddRows = false;
            this.dataGridView_Lactation.AllowUserToDeleteRows = false;
            this.dataGridView_Lactation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Lactation.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Lactation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lactation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLactationInfo,
            this.NumLactationInfo,
            this.NoteLactationInfo,
            this.DateLactationInfo,
            this.VolumeLactationInfo,
            this.EarNumberLactationInfo});
            this.dataGridView_Lactation.Location = new System.Drawing.Point(7, 8);
            this.dataGridView_Lactation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Lactation.Name = "dataGridView_Lactation";
            this.dataGridView_Lactation.ReadOnly = true;
            this.dataGridView_Lactation.RowHeadersWidth = 51;
            this.dataGridView_Lactation.RowTemplate.Height = 24;
            this.dataGridView_Lactation.Size = new System.Drawing.Size(280, 500);
            this.dataGridView_Lactation.TabIndex = 5;
            this.dataGridView_Lactation.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView_Lactation_RowStateChanged);
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
            this.NumLactationInfo.HeaderText = "Číslo laktácie";
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
            this.panel1.Controls.Add(this.button_New);
            this.panel1.Controls.Add(this.button_Edit);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Location = new System.Drawing.Point(615, 570);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 42);
            this.panel1.TabIndex = 2;
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(7, 2);
            this.button_New.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(85, 36);
            this.button_New.TabIndex = 4;
            this.button_New.Text = "Nový";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.Button_New_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(110, 2);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(84, 36);
            this.button_Edit.TabIndex = 5;
            this.button_Edit.Text = "Upraviť";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Delete.Location = new System.Drawing.Point(212, 2);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(97, 36);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Odstrániť";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(399, 2);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(97, 36);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "Zavrieť ";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Controls.Add(this.button_Save);
            this.panel2.Controls.Add(this.button_Discard);
            this.panel2.Location = new System.Drawing.Point(892, 571);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 42);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(6, 4);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(97, 34);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Uložiť";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_Discard
            // 
            this.button_Discard.Location = new System.Drawing.Point(121, 4);
            this.button_Discard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Discard.Name = "button_Discard";
            this.button_Discard.Size = new System.Drawing.Size(97, 34);
            this.button_Discard.TabIndex = 4;
            this.button_Discard.Text = "Zrušiť";
            this.button_Discard.UseVisualStyleBackColor = true;
            this.button_Discard.Click += new System.EventHandler(this.Button_Discard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(288, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kumulatívne informácie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(296, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Aktuálne informácie";
            // 
            // Cow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 617);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView_Cow);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cow";
            this.Text = "Krava";
            this.Load += new System.EventHandler(this.Reset_Window);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cow)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clafNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Health)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lactation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_Health;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridView dataGridView_Lactation;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker_LacDate;
        private System.Windows.Forms.TextBox textBox_LacNote;
        private System.Windows.Forms.TextBox textBox_LacVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Discard;
        private System.Windows.Forms.Button button_Save;
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
        private System.Windows.Forms.NumericUpDown numericUpDown_lacNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberCow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCalfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeLactationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarNumberLactationInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
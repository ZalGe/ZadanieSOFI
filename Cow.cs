using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieSOFI
{
    public enum Tab { GENERAL, HEALTH, LACTATION };
    public enum Operation { INSERT, UPDATE, DELETE };


    public partial class Cow : Form
    {
        MainPage mainPage;

        string selectedCow;
        string selectedHealthRecord;
        string selectedLactationRecord;

        double totalMilkVolume;
        int currentLactation;
        bool cowIsEliminated;

        Tab currentTab;
        Operation currentOperation;

        public Cow()
        {
            InitializeComponent();
        }

        public Cow(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        /// <summary>
        /// Method cancels window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Method resets cow window (initializes datagrids and data fields with values from database in default mode).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Window(object sender, EventArgs e)
        {
            if (currentTab == Tab.GENERAL)
            {
                // load cow data indo data gird view
                Cow_Load(sender, e);

                // filln cow data fields
                DataGridView_Cow_RowStateChanged(sender, null);

                // Health and Lactation data are already loaded by  DataGridView_Cow_RowStateChanged

                // fill health data fields
                DataGridView_Health_RowStateChanged(sender, null);

                // fill lactation data fields
                DataGridView_Lactation_RowStateChanged(sender, null);
            }

            if (currentTab == Tab.HEALTH)
            {
                // reload health data
                Health_Load(sender, e);

                // fill health data fields
                DataGridView_Health_RowStateChanged(sender, null);
            }

            if (currentTab == Tab.LACTATION)
            {
                // reload health data
                Lactation_Load(sender, e);

                // fill health data fields
                DataGridView_Lactation_RowStateChanged(sender, null);
            }

            // set data fields

            // set ear number
            textBox_earNum.ReadOnly = true;

            // set calf number
            numericUpDown_clafNum.ReadOnly = true;

            // show stat labels
            label_val_lac.Visible = true;
            label_val_volume.Visible = true;
            label_val_state.Visible = true;

            // set date time 
            dateTimePicker_healthDate.Enabled = false;

            // set health state
            textBox_healthState.ReadOnly = true;

            // set health note
            textBox_healthNote.ReadOnly = true;

            // set out of order
            checkBox_outOrder.Enabled = false;

            // enable health datagrid
            dataGridView_Health.Enabled = true;

            // set lac num
            numericUpDown_lacNum.ReadOnly = true;

            // set lac date
            dateTimePicker_LacDate.Enabled = false;

            // set lac volume
            textBox_LacVolume.ReadOnly = true;

            // set lac note
            textBox_LacNote.ReadOnly = true;

            // enable lactation datagrid
            dataGridView_Lactation.Enabled = true;

            // enable cow data grid
            dataGridView_Cow.Enabled = true;

            // hide panel 1
            panel1.Visible = true;

            // show panel 2
            panel2.Visible = false;
        }

        /// <summary>
        /// Method loads cow data from database into datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cow_Load(object sender, EventArgs e)
        {
            // load cow info
            mainPage.Database.SelectDataFromDatabase("KRAVA", dataGridView_Cow);

            // set default selected cow
             selectedCow = "NO NUMBER";

            // if there is selected row, get selected ear number
            if (dataGridView_Cow.SelectedRows.Count > 0)
            {
                selectedCow = dataGridView_Cow.SelectedRows[0].Cells["EarNumberCow"].Value.ToString();
            }
            // if not, but there is at least 1 row, select first
            else if (dataGridView_Cow.Rows.Count > 0)
            {
                dataGridView_Cow.Rows[0].Selected = true;
                selectedCow = dataGridView_Cow.SelectedRows[0].Cells["EarNumberCow"].Value.ToString();
            }
        }

        /// <summary>
        /// Method loads health data from database into datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Health_Load(object sender, EventArgs e)
        {
            // set default selected record
            selectedHealthRecord = "0";

            // load health info
            mainPage.Database.SelectDataFromDatabase("ZDRAVOTNY_ZAZNAM", "USNE_CISLO = '" + selectedCow + "'", dataGridView_Health);

            // if there is selected row, get selected ID
            if (dataGridView_Health.SelectedRows.Count > 0)
            {
                selectedHealthRecord = dataGridView_Health.SelectedRows[0].Cells["IDHealthInfo"].Value.ToString();
            }
            // if not, but there is at least 1 row, select first
            else if (dataGridView_Health.Rows.Count > 0)
            {
                dataGridView_Health.Rows[0].Selected = true;
                selectedHealthRecord = dataGridView_Health.SelectedRows[0].Cells["IDHealthInfo"].Value.ToString();
            }
        }

        /// <summary>
        /// Method loads lactation data from database into datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lactation_Load(object sender, EventArgs e)
        {
            // set default selected record
            selectedLactationRecord = "0";

            // load lactation info
            mainPage.Database.SelectDataFromDatabase("LAKTACNY_ZAZNAM", "USNE_CISLO = '" + selectedCow + "'", dataGridView_Lactation);

            // if there is selected row, get selected ID
            if (dataGridView_Lactation.SelectedRows.Count > 0)
            {
                selectedLactationRecord = dataGridView_Lactation.SelectedRows[0].Cells["IDLactationInfo"].Value.ToString();
            }
            // if not, but there is at least 1 row, select first
            else if (dataGridView_Lactation.Rows.Count > 0)
            {
                dataGridView_Lactation.Rows[0].Selected = true;
                selectedLactationRecord = dataGridView_Lactation.SelectedRows[0].Cells["IDLactationInfo"].Value.ToString();
            }

            Compute_CummulativeStats();
        }

        /// <summary>
        /// Method refreshes cow data after current row nis changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Cow_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Cow.SelectedRows.Count > 0)
            {
                // select cow
                selectedCow = dataGridView_Cow.SelectedRows[0].Cells["EarNumberCow"].Value.ToString();
                
                // load ear number
                textBox_earNum.Text = selectedCow; 
                    
                // load number of calfs
                numericUpDown_clafNum.Value = Convert.ToInt32(dataGridView_Cow.SelectedRows[0].Cells["NumberOfCalfs"].Value.ToString());

                // load cow records
                Health_Load(sender, e);
                Lactation_Load(sender, e);

                // load toal milk volume
                label_val_volume.Text = totalMilkVolume.ToString();

                // load active lactation 
                label_val_lac.Text = currentLactation.ToString();

                // load eliminated label
                label_val_state.Text = cowIsEliminated == true ? "vyradená" : "aktívna";
            }
        }

        /// <summary>
        /// Method refreshes health data after current row nis changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Health_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Health.SelectedRows.Count > 0)
            {
                // select health record
                selectedHealthRecord = dataGridView_Health.SelectedRows[0].Cells["IDHealthInfo"].Value.ToString();

                // load date
                dateTimePicker_healthDate.Value = DateTime.Parse(dataGridView_Health.SelectedRows[0].Cells["DateHealthInfo"].Value.ToString());

                // load health state
                textBox_healthState.Text = dataGridView_Health.SelectedRows[0].Cells["StateHealthInfo"].Value.ToString();
                
                // load health note
                textBox_healthNote.Text = dataGridView_Health.SelectedRows[0].Cells["NoteHealthInfo"].Value.ToString();

                // load out of order state: S - active, N - out
                if (dataGridView_Health.SelectedRows[0].Cells["CapabilityHealthInfo"].Value.ToString() == "S")
                {
                    checkBox_outOrder.Checked = false;
                }
                else
                {
                    checkBox_outOrder.Checked = true;
                }
            }
        }

        /// <summary>
        /// Method refreshes lactation data after current row nis changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Lactation_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Lactation.SelectedRows.Count > 0)
            {
                // select record ID
                selectedLactationRecord = dataGridView_Lactation.SelectedRows[0].Cells["IDLactationInfo"].Value.ToString();

                // load date
                dateTimePicker_LacDate.Value = DateTime.Parse(dataGridView_Lactation.SelectedRows[0].Cells["DateLactationInfo"].Value.ToString());

                // load lactation number 
                numericUpDown_lacNum.Value = Convert.ToInt32(dataGridView_Lactation.SelectedRows[0].Cells["NumLactationInfo"].Value.ToString());

                // load lactation volume
                textBox_LacVolume.Text = dataGridView_Lactation.SelectedRows[0].Cells["VolumeLactationInfo"].Value.ToString();

                // load lactation note
                textBox_LacNote.Text = dataGridView_Lactation.SelectedRows[0].Cells["NoteLactationInfo"].Value.ToString();

                Compute_CummulativeStats();

                // load toal milk volume
                label_val_volume.Text = totalMilkVolume.ToString();

                // load active lactation 
                label_val_lac.Text = currentLactation.ToString();

                // load eliminated label
                label_val_state.Text = cowIsEliminated == true ? "vyradená" : "aktívna";
            }
        }

        /// <summary>
        /// Method deletes current record from database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            // identify tab
            Identify_Tab(sender, e);

            // delete cow record
            if (currentTab == Tab.GENERAL)
            {
                DialogResult dialogResult = MessageBox.Show("Naozaj chcete vymazať kravu s ušným číslom: " + selectedCow + " ?",
                                                            "Vymazanie záznamu kravy", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                                            MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    mainPage.Database.DeleteFromDatabase("KRAVA", "USNE_CISLO", "'" + selectedCow + "'");
                } 
            }

            // delete health record
            if (currentTab == Tab.HEALTH)
            {
                DialogResult dialogResult = MessageBox.Show("Naozaj chcete vymazať zdravotný záznam kravy s ušným číslom: " + selectedCow + " ?",
                                                            "Vymazanie zdravotného záznamu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                                            MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    mainPage.Database.DeleteFromDatabase("ZDRAVOTNY_ZAZNAM", "ID", selectedHealthRecord);
                }
            }

            // delete lactation record
            if (currentTab == Tab.LACTATION)
            {
                DialogResult dialogResult = MessageBox.Show("Naozaj chcete vymazať laktačný záznam kravy s ušným číslom: " + selectedCow + " ?",
                                                            "Vymazanie laktačného záznamu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 
                                                            MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    mainPage.Database.DeleteFromDatabase("LAKTACNY_ZAZNAM", "ID", selectedLactationRecord);
                }
            }

            // reset window
            Reset_Window(sender, e);
        }

        /// <summary>
        /// Method switch window into insert mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_New_Click(object sender, EventArgs e)
        {
            // identify current tab
            Identify_Tab(sender, e);
            
            if (currentTab == Tab.GENERAL)
            {
                // set ear number
                textBox_earNum.Text = null;
                textBox_earNum.ReadOnly = false;

                // set calf number
                numericUpDown_clafNum.Value = 0;
                numericUpDown_clafNum.ReadOnly = false;

                // hide stat labels
                label_val_lac.Visible = false;
                label_val_volume.Visible = false;
                label_val_state.Visible = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
            }

            if (currentTab == Tab.HEALTH)
            {
                // set date time 
                dateTimePicker_healthDate.Value = DateTime.Today;
                dateTimePicker_healthDate.Enabled = true;

                // set health state
                textBox_healthState.Text = null;
                textBox_healthState.ReadOnly = false;

                // set health note
                textBox_healthNote.Text = null;
                textBox_healthNote.ReadOnly = false;

                // set out of order
                checkBox_outOrder.Checked = false;
                checkBox_outOrder.Enabled = true;

                // disable health datagrid
                dataGridView_Health.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
            }

            if (currentTab == Tab.LACTATION)
            {
                // set lac num
                numericUpDown_lacNum.Value = 0;
                numericUpDown_lacNum.ReadOnly = false;

                // set lac date
                dateTimePicker_LacDate.Value = DateTime.Today;
                dateTimePicker_LacDate.Enabled = true;

                // set lac volume
                textBox_LacVolume.Text = null;
                textBox_LacVolume.ReadOnly = false;

                // set lac note
                textBox_LacNote.Text = null;
                textBox_LacNote.ReadOnly = false;

                // disable lactation datagrid
                dataGridView_Lactation.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
            }

            // disable cow data grid
            dataGridView_Cow.Enabled = false;

            // hide panel 1
            panel1.Visible = false;
            
            // show panel 2
            panel2.Visible = true;

            // set current operation selected
            currentOperation = Operation.INSERT;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Button discards changes during insert or edit operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Discard_Click(object sender, EventArgs e)
        {
            // reset tabs
            tabControl1.TabPages.RemoveAt(0);
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);

            // select tab
            switch (currentTab)
            {
                case Tab.GENERAL:
                    tabControl1.SelectedIndex= 0; 
                    
                    break;

                case Tab.HEALTH:
                    tabControl1.SelectedIndex = 1;
                    break;

                case Tab.LACTATION:
                    tabControl1.SelectedIndex = 2;
                    break;
            }

            
           
            // refresh window
            Reset_Window(sender, e);
        }


        /// <summary>
        /// Method swicth window into edit mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            // identify current tab
            Identify_Tab(sender, e);

            if (currentTab == Tab.GENERAL)
            {
                // set ear number
                textBox_earNum.ReadOnly = false;

                // set calf number
                numericUpDown_clafNum.ReadOnly = false;

                // hide stat labels
                label_val_lac.Visible = false;
                label_val_volume.Visible = false;
                label_val_state.Visible = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
            }

            if (tabControl1.SelectedIndex == 1)
            {
                // set date time 
                dateTimePicker_healthDate.Enabled = true;

                // set health state
                textBox_healthState.ReadOnly = false;

                // set health note
                textBox_healthNote.ReadOnly = false;

                // set out of order
                checkBox_outOrder.Enabled = true;

                // disable health datagrid
                dataGridView_Health.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                // set lac num
                numericUpDown_lacNum.ReadOnly = false;

                // set lac date
                dateTimePicker_LacDate.Enabled = true;

                // set lac volume
                textBox_LacVolume.ReadOnly = false;

                // set lac note
                textBox_LacNote.ReadOnly = false;

                // disable lactation datagrid
                dataGridView_Lactation.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);

                // set current tab selected
                currentTab = Tab.LACTATION;
            }

            // disable cow data grid
            dataGridView_Cow.Enabled = false;

            // hide panel 1
            panel1.Visible = false;

            // show panel 2
            panel2.Visible = true;

            // set current operation selected
            currentOperation = Operation.UPDATE;
        }

        /// <summary>
        /// Method saves new data into database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            // ear number of cow
            string earNum = "'" + textBox_earNum.Text + "'";

            // it is an operation with general info
            if (currentTab == Tab.GENERAL)
            {
                // collect general data from components
                string calfNum = numericUpDown_clafNum.Value.ToString();
         
                // operation is insert new cow
                if (currentOperation == Operation.INSERT)
                {
                    string[] cowValues = { earNum, calfNum };
                    
                    // insert into database
                    mainPage.Database.InsertIntoDatabase("KRAVA", cowValues);
                }
                // operation is edit cow
                if (currentOperation == Operation.UPDATE)
                {
                    string[] cowColumns = { "POCET_TELAT" };
                    string[] cowValues = { calfNum };

                    // update database
                    mainPage.Database.UpdateDataInDatabase("KRAVA", cowColumns, cowValues, "USNE_CISLO", earNum);
                }
            }

            // it is an operation with health info
            if (currentTab == Tab.HEALTH)
            {
                // collect health values from components
                string healthDate = "'" + dateTimePicker_healthDate.Value.ToString("dd-MMM-yyyy", new CultureInfo("en-US")) + "'";
                string healthNote = "'" + textBox_healthNote.Text + "'";
                string healthState = "'" + textBox_healthState.Text + "'";
                string healthOK = (checkBox_outOrder.Checked == true) ? "'N'" : "'S'";

                // operation is insert
                if (currentOperation == Operation.INSERT)
                {
                    // health values
                    string[] healthValues = { "default", healthDate, healthNote, healthState, healthOK, earNum };

                    // insert into database
                    mainPage.Database.InsertIntoDatabase("ZDRAVOTNY_ZAZNAM", healthValues);
                }

                // operation is update
                if (currentOperation == Operation.UPDATE)
                {
                    string[] healthValues = { healthDate, healthNote, healthState, healthOK, earNum };
                    string[] healthColumns = { "DATUM", "POZNAMKA", "ZDRAVOTNY_STAV", "ZDRAVOTNA_SPOSOBILOST", "USNE_CISLO" };
                   
                    // update database
                    mainPage.Database.UpdateDataInDatabase("ZDRAVOTNY_ZAZNAM", healthColumns, healthValues, "ID", selectedHealthRecord);
                }
            }

            // it is an operation with lactation info
            if (currentTab == Tab.LACTATION)
            {
                // collect lactation values 
                string lacDate = "'" + dateTimePicker_LacDate.Value.ToString("dd-MMM-yyyy", new CultureInfo("en-US")) + "'";
                string lacNote = "'" + textBox_LacNote.Text + "'";
                string lacNumber = numericUpDown_lacNum.Text;
                string lacVolume = textBox_LacVolume.Text.Replace(",", ".");

                // opertaion is insert
                if (currentOperation == Operation.INSERT)
                {
                    string[] lacValues = { "default", lacDate, lacNote, lacNumber, lacVolume, earNum };

                    // insert into database
                    mainPage.Database.InsertIntoDatabase("LAKTACNY_ZAZNAM", lacValues);
                }

                // opertaion is update
                if (currentOperation == Operation.UPDATE)
                {
                    string[] lacColumns = { "DATUM", "POZNAMKA", "CISLO_LAKTACIE", "OBJEM_MLIEKA", "USNE_CISLO" };
                    string[] lacValues = { lacDate, lacNote, lacNumber, lacVolume, earNum };

                    // update database
                    mainPage.Database.UpdateDataInDatabase("LAKTACNY_ZAZNAM", lacColumns, lacValues, "ID", selectedLactationRecord);
                }
            }

            // refresh app window 
            Button_Discard_Click(sender, e);
        }

        private void Identify_Tab(object sender, EventArgs e)
        {

            // select tab
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    currentTab = Tab.GENERAL;
                    break;

                case 1:
                    currentTab = Tab.HEALTH;
                    break;

                case 2:
                    currentTab = Tab.LACTATION;
                    break;
            }


        }

        private void Compute_CummulativeStats()
        {
            if (dataGridView_Lactation.Rows.Count == 0)
            {
                totalMilkVolume = 0;
                currentLactation = 0;
                cowIsEliminated = false;
            }
            else
            {
                totalMilkVolume = dataGridView_Lactation.Rows
                                  .Cast<DataGridViewRow>()
                                  .Select(row => Convert.ToDouble(row.Cells["VolumeLactationInfo"].Value))
                                  .Sum();

                currentLactation = dataGridView_Lactation.Rows
                                   .Cast<DataGridViewRow>()
                                   .Select(row => Convert.ToInt32(row.Cells["NumLactationInfo"].Value))
                                   .Max();

                cowIsEliminated = dataGridView_Health.Rows
                                  .Cast<DataGridViewRow>()
                                  .Select(row => row.Cells["CapabilityHealthInfo"].Value.ToString())
                                  .Any(val => val == "N");
            }
        }
    }
}

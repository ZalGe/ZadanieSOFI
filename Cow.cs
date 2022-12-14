using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Cow()
        {
            InitializeComponent();
        }

        public Cow(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            Cow_Load(sender, e);
            Health_Load(sender, e);
            Lactation_Load(sender, e);
        }

        private void Cow_Load(object sender, EventArgs e)
        {
            // update cow info
            mainPage.Database.SelectDataFromDatabase("KRAVA", dataGridView1);

            // update selected cow
             selectedCow = "NO NUMBER";

            // if there is selected row, get selected ear number
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedCow = dataGridView1.SelectedRows[0].Cells["EarNumberCow"].Value.ToString();
            }
            // if not, get first record in database
            else if (dataGridView1.Rows.Count > 0)
            {
                selectedCow = dataGridView1.Rows[0].Cells["EarNumberCow"].Value.ToString();
            }
        }

        private void Health_Load(object sender, EventArgs e)
        {
            // update health info
            mainPage.Database.SelectDataFromDatabase("ZDRAVOTNY_ZAZNAM", "USNE_CISLO = '" + selectedCow + "'", dataGridView2);
        }

        private void Lactation_Load(object sender, EventArgs e)
        {
            // update lactation info
            mainPage.Database.SelectDataFromDatabase("LAKTACNY_ZAZNAM", "USNE_CISLO = '" + selectedCow + "'", dataGridView3);

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               // select cow
                selectedCow = dataGridView1.SelectedRows[0].Cells["EarNumberCow"].Value.ToString();
                textBox_earNum.Text = selectedCow; 
                    
                // load number of calfs
                numericUpDown_clafNum.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NumberOfCalfs"].Value.ToString());

                // load cow data
                Health_Load(sender, e);
                Lactation_Load(sender, e);
            }
        }

        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // select cow
                selectedHealthRecord = dataGridView2.SelectedRows[0].Cells["IDHealthInfo"].Value.ToString();

                // show date
                dateTimePicker_healthDate.Value = DateTime.Parse(dataGridView2.SelectedRows[0].Cells["DateHealthInfo"].Value.ToString());

                // show health state
                textBox_healthState.Text = dataGridView2.SelectedRows[0].Cells["StateHealthInfo"].Value.ToString();
                
                // show health note
                textBox_healthNote.Text = dataGridView2.SelectedRows[0].Cells["NoteHealthInfo"].Value.ToString();

                // show out of order state: s - active, n - out
                if (dataGridView2.SelectedRows[0].Cells["CapabilityHealthInfo"].Value.ToString() == "S")
                {
                    checkBox_outOrder.Checked = false;
                }
                else
                {
                    checkBox_outOrder.Checked = true;
                }
            }
        }

        private void dataGridView3_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Naozaj chcete vymazať kravu s ušným číslom: " + selectedCow, 
                "Vymazanie kravy", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                mainPage.Database.DeleteFromDatabase(tableCow, selectedCow);
                mainPage.Database.SelectDataFromDatabase(tableCow, dataGridView1);
            }
        }

        MainPage mainPage;

        string selectedCow;
        string selectedHealthRecord;
        Tab currentTab;
        Operation currentOperation;



        string tableCow = "KRAVA";
        string tableLactation = "LAKTACNY_ZAZNAM";
        string tableHealth = "ZDRAVOTNY_ZAZNAM";

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
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

                // set current tab selected
                currentTab = Tab.GENERAL;
            }

            if (tabControl1.SelectedIndex == 1)
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
                dataGridView2.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);

                // set current tab selected
                currentTab = Tab.HEALTH;

            }

            if (tabControl1.SelectedIndex == 2)
            {
                // set lac num
                textBox_lacNum.Text = null;
                textBox_lacNum.ReadOnly = false;

                // set lac date
                dateTimePicker_lacDate.Value = DateTime.Today;
                dateTimePicker_lacDate.Enabled = true;

                // set lac volume
                textBox_lacVolume.Text = null;
                textBox_lacVolume.ReadOnly = false;

                // set lac note
                textBox_lacNote.Text = null;
                textBox_lacNote.ReadOnly = false;

                // disable lactation datagrid
                dataGridView3.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);

                // set current tab selected
                currentTab = Tab.LACTATION;
            }

            // disable cow data grid
            dataGridView1.Enabled = false;

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

        private void button5_Click(object sender, EventArgs e)
        {
            // reset tabs
            tabControl1.TabPages.RemoveAt(0);
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);

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
            dataGridView2.Enabled = true;
            
            // set lac num
            textBox_lacNum.ReadOnly = true;

            // set lac date
            dateTimePicker_lacDate.Enabled = false;

            // set lac volume
            textBox_lacVolume.ReadOnly = true;

            // set lac note
            textBox_lacNote.ReadOnly = true;

            // enable lactation datagrid
            dataGridView3.Enabled = true;
          
            // enable cow data grid
            dataGridView1.Enabled = true;

            // hide panel 1
            panel1.Visible = true;

            // show panel 2
            panel2.Visible = false;

            // refresh app
            Data_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
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

                // set current tab selected
                currentTab = Tab.GENERAL;
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
                dataGridView2.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);

                // set current tab selected
                currentTab = Tab.HEALTH;

            }

            if (tabControl1.SelectedIndex == 2)
            {
                // set lac num
                textBox_lacNum.ReadOnly = false;

                // set lac date
                dateTimePicker_lacDate.Enabled = true;

                // set lac volume
                textBox_lacVolume.ReadOnly = false;

                // set lac note
                textBox_lacNote.ReadOnly = false;

                // disable lactation datagrid
                dataGridView3.Enabled = false;

                // hide tabs
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);

                // set current tab selected
                currentTab = Tab.LACTATION;
            }

            // disable cow data grid
            dataGridView1.Enabled = false;

            // hide panel 1
            panel1.Visible = false;

            // show panel 2
            panel2.Visible = true;

            // set current operation selected
            currentOperation = Operation.UPDATE;
        }
    }
}

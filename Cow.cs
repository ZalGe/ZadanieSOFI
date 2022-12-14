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
                textBox1.Text = selectedCow; 
                    
                // load number of calfs
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NumberOfCalfs"].Value.ToString());

                // load cow data
                Health_Load(sender, e);
                Lactation_Load(sender, e);
            }
        }

        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

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
        string tableCow = "KRAVA";
        string tableLactation = "LAKTACNY_ZAZNAM";
        string tableHealth = "ZDRAVOTNY_ZAZNAM";

    }
}

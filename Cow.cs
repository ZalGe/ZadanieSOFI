using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Cow_Load(object sender, EventArgs e)
        {
            string tableCow = "KRAVA";
            string tableLactation = "LAKTACNY_ZAZNAM";
            string tableHealth = "ZDRAVOTNY_ZAZNAM";

            mainPage.Database.SelectDataFromDatabase(tableCow, dataGridView1);
            dataSetCow = mainPage.Database.Data;

            mainPage.Database.SelectDataFromDatabase(tableHealth, dataGridView2);
            dataSetHealth = mainPage.Database.Data;

            mainPage.Database.SelectDataFromDatabase(tableLactation, dataGridView3);
            dataSetLactation = mainPage.Database.Data;


        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["EarNumberCow"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NumberOfCalfs"].Value.ToString());
                
            }
        }

        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridView3_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        MainPage mainPage;
        DataSet dataSetCow;
        DataSet dataSetLactation;
        DataSet dataSetHealth;
    }
}

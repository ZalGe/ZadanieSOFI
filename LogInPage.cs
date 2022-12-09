using Oracle.DataAccess.Client;
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
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        public LogInPage(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPage.Database.Name = textBox1.Text;
            mainPage.Database.Password = textBox2.Text;

            mainPage.Database.DatabaseConnect();

            if (mainPage.Database.Connection.State == ConnectionState.Open) 
            {
                mainPage.EnableShowTool = true;
                mainPage.EnableDisconectTool = true;
                Close(); 
            }
            else
                textBox2.Text = null;
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        MainPage mainPage;
    }
}

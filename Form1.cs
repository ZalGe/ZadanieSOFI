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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();


            AboutPage aboutPage = new AboutPage();

            aboutPage.MdiParent = this;
            aboutPage.Show();

            showToolStripMenuItem.Enabled = false;
            disconnectToolStripMenuItem.Enabled = false;

            Database = new Database();
        }

        public bool EnableShowTool
        {
            set => showToolStripMenuItem.Enabled = value;
            get => showToolStripMenuItem.Enabled;
        }

        public bool EnableDisconectTool
        {
            set => disconnectToolStripMenuItem.Enabled = value;
            get => disconnectToolStripMenuItem.Enabled;
        }
        internal Database Database 
        { 
            get => database; 
            set => database = value; 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage = new AboutPage();

            aboutPage.MdiParent = this;
            aboutPage.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage(this);

            logInPage.MdiParent = this;
            logInPage.Show();
         
            showToolStripMenuItem.Enabled = EnableShowTool;
            disconnectToolStripMenuItem.Enabled = EnableDisconectTool;
        }

        private void cowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cow cow = new Cow(this);

            cow.MdiParent = this;
            cow.Show();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.DatabaseDisconnect();

            EnableDisconectTool= false;
            EnableShowTool= false;
        }

        Database database;
    }
}

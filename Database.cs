using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieSOFI
{
    internal class Database
    {
        public void DatabaseConnect()
        {
            try
            {
                Connection = new OracleConnection();
                Connection.ConnectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 147.175.137.84)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = student))); User Id = " + Name + "; Password = " + Password + "; ";

                Connection.Open();
                MessageBox.Show(Connection.State.ToString(), "Stav spojenia");
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Chyba pripojenia");
            }
        }

        public void DatabaseDisconnect()
        {
            if(Connection.State == ConnectionState.Open)
            {
                Connection.Close();
                MessageBox.Show(Connection.State.ToString(), "Stav spojenia");
            }
        }

        public void InsertIntoDatabase (string tableName, string[] values)
        {
            
        }

        public void SelectDataFromDatabase(string tableName, DataGridView dataGridView)
        {
            string select = "SELECT * FROM " + tableName;

            Data = new DataSet();

            Adapter = new OracleDataAdapter(select, Connection);
            Adapter.Fill(Data, tableName);

            dataGridView.DataSource = Data.Tables[tableName];
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public OracleConnection Connection { get => connection; set => connection = value; }
        public OracleDataAdapter Adapter { get => adapter; set => adapter = value; }
        public OracleCommand Sql { get => sql; set => sql = value; }
        public DataSet Data { get => data; set => data = value; }

        private string name;
        private string password;
        private OracleConnection connection;
        private OracleDataAdapter adapter;
        private OracleCommand sql;
        private DataSet data;

    }
}

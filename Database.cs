﻿using Oracle.DataAccess.Client;
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
                MessageBox.Show(e.Message, "Chyba pripojenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void DeleteFromDatabase (string tableName, string idCol, string idVal)
        {
            try
            {
                string delete = "DELETE FROM " + tableName + " WHERE " + idCol + " = " + idVal;

                Sql = new OracleCommand(delete, Connection);
                int result = Sql.ExecuteNonQuery();

                MessageBox.Show("Záznam bol vymazaný", "Zmazanie záznamu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Chyba pri vkladaní záznamu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertIntoDatabase (string tableName, string[] values)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                stringBuilder.Append(values[i] + ", ");
            }

            stringBuilder.Length -= 2;

            try
            {
                string insert = "INSERT INTO " + tableName + " VALUES (" + stringBuilder.ToString() + ")";

                Sql = new OracleCommand(insert, Connection);
                int result = Sql.ExecuteNonQuery();

                MessageBox.Show("Záznam bol pridaný", "Pridanie záznamu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Chyba pri vkladaní záznamu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertIntoDatabase(string tableName, string columns, string values)
        {
            try
            {
                string insert = "INSERT INTO " + tableName + "(" + columns + ") " + "VALUES (" + values + ")";

                Sql = new OracleCommand(insert, Connection);
                int result = Sql.ExecuteNonQuery();

                MessageBox.Show("Záznam bol pridaný", "Pridanie záznamu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Chyba pri vkladaní záznamu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDataInDatabase(string tableName, string[] columns, string[] values, string namePK, string valuePK)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < columns.Length; i++)
            {
                stringBuilder.Append(columns[i] + " = " + values[i] + ", ");
            }

            stringBuilder.Length -= 2;

            try
            {
                string update = "UPDATE " + tableName + " SET " + stringBuilder.ToString() + " WHERE " + namePK + " = " + valuePK;
                Sql = new OracleCommand(update, Connection);
                int result = Sql.ExecuteNonQuery();

                MessageBox.Show("Záznam bol upravený", "Upravenie záznamu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Chyba pri upravovaní záznamu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelectDataFromDatabase(string tableName, DataGridView dataGridView)
        {
            string select = "SELECT * FROM " + tableName;

            Data = new DataSet();

            Adapter = new OracleDataAdapter(select, Connection);
            Adapter.Fill(Data, tableName);

            dataGridView.DataSource = Data.Tables[tableName];
        }

        public void SelectDataFromDatabase(string tableName, string condition, DataGridView dataGridView)
        {
            string select = "SELECT * FROM " + tableName + " WHERE " + condition;

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

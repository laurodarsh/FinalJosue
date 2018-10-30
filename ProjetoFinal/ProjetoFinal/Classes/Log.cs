using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Classes
{
    public class Log
    {
        private int id = 0;
        private string description;
        private string type;
        private DateTime date;

        public Log(string description, string type, DateTime date)
        {
            this.description = description;
            this.type = type;
            this.date = date;
        }

        public Log()
        {
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public static void SaveLog(string description, string type, DateTime date)
        {
            string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            //Conectar
            sqlConnect.Open();
            string sql = "INSERT INTO LOG (DESCRIPTION, TYPE, DATE) VALUES (@description, @type, @date)";
            //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
            //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

            SqlCommand cmd = new SqlCommand(sql, sqlConnect);

            cmd.Parameters.Add(new SqlParameter("@description", description));
            cmd.Parameters.Add(new SqlParameter("@type", type));
            cmd.Parameters.Add(new SqlParameter("@date", date));

            cmd.ExecuteNonQuery();

        }
    }
}

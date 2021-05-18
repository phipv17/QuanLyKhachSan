using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BusinessLogicLayer
    {
        DataAcessLayer da = new DataAcessLayer();
        private static BusinessLogicLayer instance;

        public static BusinessLogicLayer Instance {   
            get { if (instance == null) instance = new BusinessLogicLayer(); return BusinessLogicLayer.instance; }
            private set { BusinessLogicLayer.instance = value; }
    }
        public BusinessLogicLayer() { }
       
        public bool Login(string userName, string passWord, string roll)
        {
            string query = "SELECT * FROM Account WHERE userName = N'" + userName + "' AND passwords = N'" + passWord +
                "' AND roll = N'" + roll + "'" ;

            DataTable result = da.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool Register(string userName, string password, string roll)
        {
            string query = "Insert into Account values (N'" + userName + "' , N'" + password + "' , N'" + roll + "')";
            DataTable result = da.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

    }
}

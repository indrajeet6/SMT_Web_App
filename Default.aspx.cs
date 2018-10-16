using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace SMT_Web_Form
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) 
        {
            /* Need to make code to get Connection String from External Web Config FIle instead of hard code.*/
            string ConnString = @"Server=MSI-LAPTOP;Database=SMT_DB;Trusted_Connection=True;";
            //string ConnString = ConfigurationManager.ConnectionStrings["Conn_String"].ConnectionString;
            string strSQLcmd = "SELECT MAX(INC) FROM dbo.SMT_Data";
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.CommandText = strSQLcmd;
            sqlComm.Connection = conn;
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(strSQLcmd, conn);
            DataSet ds = new DataSet();
            int intRowCount = adap.Fill(ds);
            string strVal = string.Empty;
            if (intRowCount>0)
            {
                strVal = ds.Tables[0].Rows[0][0].ToString();
            }
            conn.Close();
            try
            {
                //Added the Try Catch Block to suppress the error that Label 2 is null when navigating away from the home page.
                LblLastINCUsed.Text = strVal;
            }
            catch (Exception ex)
            {
                
            }
            
            
            
        }

    }
}
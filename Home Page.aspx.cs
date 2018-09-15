using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SMT_Web_Form
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) 
        {

            string ConnString = @"Server=tcp:indrajeet.database.windows.net,1433;Initial Catalog=SMT_DB;Persist Security Info=False;User ID=indrajeet6;Password=Indrani7&;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
                string n = ex.Message;
                string strLogFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"Logs\ErrorLog-" + DateTime.Today.Date.ToShortDateString().ToString()+ ".txt");
                StreamWriter w = File.AppendText(strLogFilePath);
                w.Write("Log Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("{0}:{1}:{2}", ex.Source,ex.StackTrace,ex.Message);
                w.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                w.Close();
            }
            
            
            
        }

    }
}
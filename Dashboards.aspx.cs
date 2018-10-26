using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace SMT_Web_Form
{
    public partial class Dashboards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Add Code for a charting control, refer to article bookmarked in edge for details.
                SqlCommand sqlCmd = new SqlCommand();
                SqlConnection sqlConn = new SqlConnection();
                Utilities Util = new Utilities();
                string strConnString = Util.GetConnectionString();
                string strSqlCmd = "Select SMT_Data.Requestor as 'Patrtner Name', COUNT (INC) AS 'Count of Incidents' from SMT_Data GROUP BY SMT_Data.Requestor";

                sqlConn.ConnectionString = strConnString;
                sqlCmd.CommandText = strSqlCmd;
                sqlCmd.Connection = sqlConn;
                sqlConn.Open();
                SqlDataReader sqlReader;
                sqlReader = sqlCmd.ExecuteReader();
                Chart1.DataBindTable(sqlReader, "Patrtner Name");
                sqlReader.Close();
                sqlConn.Close();



            }
        }
    }
}
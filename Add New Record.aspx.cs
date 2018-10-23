using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SMT_Web_Form
{
    public partial class _Default : Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //lblINCNo.Text = "This is a Test";
            //string ConnString = @"Server=MSI-LAPTOP;Database=SMT_DB;Trusted_Connection=True;";
            Utilities Util = new Utilities();
            string ConnString = Util.GetConnectionString();
            
            string strMaxINCNoCmd = "SELECT MAX(INC) FROM SMT_Data";
            SqlConnection connINC = new SqlConnection(ConnString);
            SqlDataAdapter adap = new SqlDataAdapter(strMaxINCNoCmd, connINC);
            DataSet ds = new DataSet();
            int intRowCount = adap.Fill(ds);
            string strVal = string.Empty;
            
            if (intRowCount > 0)
            {
                strVal= ds.Tables[0].Rows[0][0].ToString();
            }
            connINC.Close();

            int intTempNo = Convert.ToInt32(strVal.Replace("INC", ""))+1;
            int intLen = 4- intTempNo.ToString().Length;
            string strINCNo = string.Empty;
            if (intLen>0)
            {
                for (int i=0;i<intLen;i++)
                {
                    strINCNo = strINCNo + "0";
                }
                strINCNo = strINCNo + intTempNo;
            }
            string strNewINC = "INC" + strINCNo;
            lblINCNo.Text = strNewINC;


            //Response.Write("<script>alert('Incident Number is " + strINCNumber +"');</script>");
            string args = "'" + lblINCNo.Text + "', '" + txtBox3.Text + "', '" + txtBox4.Text + "', '" + txtBox5.Text + "', '" + txtBox6.Text + "', '" + txtBox7.Text + "', '" + txtBox8.Text + "', '" + txtBox9.Text + "', '" + 
                txtBox10.Text + "', '" + txtBox11.Text + "', '" + txtBox12.Text + "', '" + txtBox13.Text + "', '" + txtBox14.Text + "', '" + txtBox15.Text + "', '" + txtBox16.Text + "', '" + txtBox17.Text + "', '" + 
                txtBox18.Text + "', '" + txtBox19.Text + "', '" + txtBox20.Text + "', '" + txtBox21.Text + "', '" + txtBox22.Text + "', '" + txtBox23.Text + "'";
            args.Replace("\"", "''");

            string strDateVerify1 = Util.VerifyDate(txtBox5.Text);
            string strDateVerify2 = Util.VerifyDate(txtBox23.Text);

            if (strDateVerify1 != "Date Verified" || strDateVerify2 != "Date Verified")
            {
                string strTemp = "Input Received Date - " + strDateVerify1 + " Intake Closed Date - " + strDateVerify2;
                Response.Write("<script>alert('" + strTemp + "')</script>");
                //RegisterStartupScript("DisplayError", "<script language=javascript>alert('Input Received Date - " + strDateVerify1 + " Intake Closed Date - '" + strDateVerify2 + "');</script>");
            }
            else
            {
                string strSQLcmd = "Exec Insert_Record " + args;
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand sqlComm = new SqlCommand();
                SqlCommand sqlGetINC = new SqlCommand();
                sqlComm.CommandText = strSQLcmd;
                sqlComm.Connection = conn;
                conn.Open();
                sqlComm.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('Incident has been recorded in system. Incident Number: " + strNewINC + "')</script>");
            }

            
        }
    }


}
﻿using System;
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToUpper();
            string strINCNumber = TextBox1.Text;
            //Response.Write("<script>alert('Incident Number is " + strINCNumber +"');</script>");
            string ConnString = @"Server=tcp:indrajeet.database.windows.net,1433;Initial Catalog=SMT_DB;Persist Security Info=False;User ID=indrajeet6;Password=Indrani7&;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string strSQLcmd = "Exec Get_Record " + TextBox1.Text;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            //SqlCommand strSQLComm = new SqlCommand(strSQLcmd,conn);
            SqlDataAdapter adap = new SqlDataAdapter(strSQLcmd,conn);
            DataSet ds = new DataSet();
            int intRowCount = adap.Fill(ds);

            //Response.Write("<script>alert('" + ds.Tables[0].Rows[0]["Supplier"].ToString() + "');</script>");
            if (intRowCount>0)
            {
                TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0][3].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0][4].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0][5].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0][6].ToString();
                TextBox9.Text = ds.Tables[0].Rows[0][7].ToString();
                TextBox10.Text = ds.Tables[0].Rows[0][8].ToString();
                TextBox11.Text = ds.Tables[0].Rows[0][9].ToString();
                TextBox12.Text = ds.Tables[0].Rows[0][10].ToString();
                TextBox13.Text = ds.Tables[0].Rows[0][11].ToString();
                TextBox14.Text = ds.Tables[0].Rows[0][12].ToString();
                TextBox15.Text = ds.Tables[0].Rows[0][13].ToString();
                TextBox16.Text = ds.Tables[0].Rows[0][14].ToString();
                TextBox17.Text = ds.Tables[0].Rows[0][15].ToString();
                TextBox18.Text = ds.Tables[0].Rows[0][16].ToString();
                TextBox19.Text = ds.Tables[0].Rows[0][17].ToString();
                TextBox20.Text = ds.Tables[0].Rows[0][18].ToString();
                TextBox21.Text = ds.Tables[0].Rows[0][19].ToString();
                TextBox22.Text = ds.Tables[0].Rows[0][20].ToString();
                TextBox23.Text = ds.Tables[0].Rows[0][21].ToString();

            }
            else
            {
                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;
                TextBox4.Text = string.Empty;
                TextBox5.Text = string.Empty;
                TextBox6.Text = string.Empty;
                TextBox7.Text = string.Empty;
                TextBox8.Text = string.Empty;
                TextBox9.Text = string.Empty;
                TextBox10.Text = string.Empty;
                TextBox11.Text = string.Empty;
                TextBox12.Text = string.Empty;
                TextBox13.Text = string.Empty;
                TextBox14.Text = string.Empty;
                TextBox15.Text = string.Empty;
                TextBox16.Text = string.Empty;
                TextBox17.Text = string.Empty;
                TextBox18.Text = string.Empty;
                TextBox19.Text = string.Empty;
                TextBox20.Text = string.Empty;
                TextBox21.Text = string.Empty;
                TextBox22.Text = string.Empty;
                TextBox23.Text = string.Empty;

                Response.Write("<script>alert('Incident Number Not Found');</script>");
            }
            conn.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string strINCNumber = TextBox1.Text;
            //Response.Write("<script>alert('Incident Number is " + strINCNumber +"');</script>");
            string args = "'"+ TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "', '" + TextBox8.Text + "', '" + TextBox9.Text + "', '" + TextBox10.Text + "', '" + TextBox11.Text + "', '" + TextBox12.Text + "', '" + TextBox13.Text + "', '" + TextBox14.Text + "', '" + TextBox15.Text + "', '" + TextBox16.Text + "', '" + TextBox17.Text + "', '" + TextBox18.Text + "', '" + TextBox19.Text + "', '" + TextBox20.Text + "', '" + TextBox21.Text + "', '" + TextBox22.Text + "', '" + TextBox23.Text+"'";
            args.Replace("\"", "''");
            string ConnString = @"Server=tcp:indrajeet.database.windows.net,1433;Initial Catalog=SMT_DB;Persist Security Info=False;User ID=indrajeet6;Password=Indrani7&;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string strSQLcmd = "Exec Insert_Record " + args;
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.CommandText = strSQLcmd;
            sqlComm.Connection = conn;
            conn.Open();
            sqlComm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
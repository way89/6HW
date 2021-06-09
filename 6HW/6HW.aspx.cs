using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _6HW
{
    public partial class _6HW : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection o_conn = connect_DB();
            try
            {
                o_conn.Open();
                SqlCommand o_com = new SqlCommand("select * from Users", o_conn);
                SqlDataReader o_data = o_com.ExecuteReader();
                for (; o_data.Read();)
                {
                    for (int i = 0; i < o_data.FieldCount; i++)
                    {
                        Response.Write(o_data[i]);

                    }
                    Response.Write("<br />");
                }
                o_conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            tb_Name.Visible = true;
            btn_Del.Visible = true;

        }

        SqlConnection connect_DB()
        {
            string s = "";
            s = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Test;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID=sa;Password=12345";
            SqlConnection o_conn = new SqlConnection(s);
            return o_conn;
        }
        protected void btn_Del_Click(object sender, EventArgs e)
        {
            SqlConnection o_conn = connect_DB();
            try
            {
                o_conn.Open();
                SqlCommand o_com = new SqlCommand("DELETE FROM Users WHERE Name=N'" + tb_Name.Text + "';", o_conn);
                int result = o_com.ExecuteNonQuery();
                if (result < 1)
                {
                    lb_Msg.Text = "無此一資料";
                }
                else
                {
                    Response.Redirect("./6HW.aspx");
                }
                o_conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;

namespace Hospital_Management_System
{
    public partial class doctor_apply_leave : System.Web.UI.Page
    {
        StringBuilder table1 = new StringBuilder();
        StringBuilder table2 = new StringBuilder();
        StringBuilder table3 = new StringBuilder();
        StringBuilder table4 = new StringBuilder();
        StringBuilder table5 = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
            con.Open();

            SqlCommand cd = new SqlCommand("select * from doctor where id='" + Request.QueryString[0] + "' ", con);
            SqlDataReader dr1 = cd.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Read();
                Label1.Text = Convert.ToString(dr1["name"]);

            }


            table1.AppendFormat("<ul class='treeview-menu'>");

            table1.AppendFormat("<li><a href='view_doctor_info.aspx?id=" + Request.QueryString[0] + "'>View Information</a></li>");

            table1.AppendFormat("</ul>");
            PlaceHolder1.Controls.Add(new Literal { Text = table1.ToString() });


            table2.AppendFormat("<ul class='treeview-menu'>");

            table2.AppendFormat("<li><a href='doctor_appointment_list.aspx?id=" + Request.QueryString[0] + "'>Appointments List</a></li>");

            table2.AppendFormat("</ul>");
            PlaceHolder2.Controls.Add(new Literal { Text = table2.ToString() });

            table3.AppendFormat("<ul class='treeview-menu'>");

            table3.AppendFormat("<li><a href='doctor_leave_list.aspx?id=" + Request.QueryString[0] + "'>Leaves List</a></li>");
            table3.AppendFormat("<li><a href='doctor_apply_leave.aspx?id=" + Request.QueryString[0] + "'>Apply Leaves</a></li>");

            table3.AppendFormat("</ul>");
            PlaceHolder3.Controls.Add(new Literal { Text = table3.ToString() });

            table4.AppendFormat("<ul class='treeview-menu'>");

            table4.AppendFormat("<li><a href='doctor_salary.aspx?id=" + Request.QueryString[0] + "'>View Salary</a></li>");

            table4.AppendFormat("</ul>");
            PlaceHolder4.Controls.Add(new Literal { Text = table4.ToString() });





            table5.AppendFormat("<a href='doctor_dashboard.aspx?id=" + Request.QueryString[0] + "' class='logo'>");

            table5.AppendFormat("<h3 style='color:white;'>Doctor Panel</h3>");

            table5.AppendFormat(" </a>");
            PlaceHolder5.Controls.Add(new Literal { Text = table5.ToString() });

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string iid;
            string qy = "select Leave_id from leave order by Leave_id Desc";
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
            con.Open();
            SqlCommand cmdd = new SqlCommand(qy, con);
            SqlDataReader dr = cmdd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                iid = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                iid = ("00001");
            }
            else
            {
                iid = ("00001");
            }
            String idd = iid.ToString();
            string status = "Pending";
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into leave(Leave_id,doctor_id,from_date,no_of_days,reason,status) values('" + idd + "','" + TextBox1.Text + "','"+Calendar1.SelectedDate.ToString()+"','" + TextBox2.Text + "','" + TextBox3.Text + "','" + status + "')", con);
            int query = cmd.ExecuteNonQuery();
            if (query > 0)
            {
                Label2.Visible = true;
                Label2.Text = "Leave Apply successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                


            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
               


            }

            con.Close();
        }
    }
}
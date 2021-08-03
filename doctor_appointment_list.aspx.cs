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
    public partial class doctor_appointment_list : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
       
        StringBuilder table1 = new StringBuilder();
        StringBuilder table2 = new StringBuilder();
        StringBuilder table3 = new StringBuilder();
        StringBuilder table4 = new StringBuilder();
        StringBuilder table5 = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admit where allocated_doctor_id='"+Request.QueryString[0]+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            table.Append("<center><table style='width:1000px; heigth:auto;' class='table'>");
            table.Append("<tr bgcolor='black'>");
            table.Append("<th colspan='6'><center>APPOINTMENT LIST</center></h2></th>");
            table.Append("</tr>");
            table.Append("<tr>");
            table.Append("<th bgcolor='#5DADE2'>PATIENT ID</th>");
            table.Append("<th bgcolor='#5DADE2'>PATIENT NAME</th>");
            table.Append("<th bgcolor='#5DADE2'>ROOM NO</th>");
            table.Append("<th bgcolor='#5DADE2'>DATE OF ADMIT</th>");
           

            table.Append("</tr>");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    table.Append("<tr>");
                    table.Append("<td>" + dr[1] + "</td>");
                    table.Append("<td>" + dr[2] + "</td>");
                    table.Append("<td>" + dr[5] + "</td>");
                    table.Append("<td>" + dr[6] + "</td>");
                   


                    table.Append("</tr>");
                }
            }
            table.Append("</center></table>");
            PlaceHolder5.Controls.Add(new Literal { Text = table.ToString() });




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
            PlaceHolder6.Controls.Add(new Literal { Text = table5.ToString() });

            con.Close();
            con.Open();
           
            SqlCommand cd = new SqlCommand("select * from doctor where id='" + Request.QueryString[0] + "' ", con);
            SqlDataReader dr1 = cd.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Read();
                Label1.Text = Convert.ToString(dr1["name"]);

            }
        }
    }
}
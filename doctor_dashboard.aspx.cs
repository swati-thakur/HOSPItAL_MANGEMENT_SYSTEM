using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data; 

namespace Hospital_Management_System
{
    public partial class doctor_dashboard : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        StringBuilder table1 = new StringBuilder();
        StringBuilder table2 = new StringBuilder();
        StringBuilder table3 = new StringBuilder();
        StringBuilder table4 = new StringBuilder();
        StringBuilder table5 = new StringBuilder();

        private void Getdata()
        {

            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
         
            con.Open();
            string status = "Approve";
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from leave where doctor_id='" + Request.QueryString[0] + "' and status='" + status + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Label3.Text = dt.Rows[0][0].ToString();
            



        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Getdata();
       

            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
            con.Open();
            SqlCommand cd = new SqlCommand("select * from doctor where id='" + Request.QueryString[0] + "' ", con);
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Label1.Text = Convert.ToString(dr["name"]);

            }



            table.AppendFormat("<ul class='treeview-menu'>");

            table.AppendFormat("<li><a href='view_doctor_info.aspx?id=" + Request.QueryString[0] + "'>View Information</a></li>");

            table.AppendFormat("</ul>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });


            table1.AppendFormat("<ul class='treeview-menu'>");

            table1.AppendFormat("<li><a href='doctor_appointment_list.aspx?id=" + Request.QueryString[0] + "'>Appointments List</a></li>");

            table1.AppendFormat("</ul>");
            PlaceHolder2.Controls.Add(new Literal { Text = table1.ToString() });

            table2.AppendFormat("<ul class='treeview-menu'>");

            table2.AppendFormat("<li><a href='doctor_leave_list.aspx?id=" + Request.QueryString[0] + "'>Leaves List</a></li>");
            table2.AppendFormat("<li><a href='doctor_apply_leave.aspx?id=" + Request.QueryString[0] + "'>Apply Leaves</a></li>");

            table2.AppendFormat("</ul>");
            PlaceHolder3.Controls.Add(new Literal { Text = table2.ToString() });

            table3.AppendFormat("<ul class='treeview-menu'>");

            table3.AppendFormat("<li><a href='doctor_salary.aspx?id=" + Request.QueryString[0] + "'>View Salary</a></li>");

            table3.AppendFormat("</ul>");
            PlaceHolder4.Controls.Add(new Literal { Text = table3.ToString() });


            table4.AppendFormat("<li><a href='change_doctor_password.aspx?id=" + Request.QueryString[0] + "'>Change Password</a></li>");

           
            PlaceHolder5.Controls.Add(new Literal { Text = table4.ToString() });


              
              
              
           



        table5.AppendFormat("<a href='doctor_dashboard.aspx?id=" + Request.QueryString[0] + "' class='logo'>");

            table5.AppendFormat("<h3 style='color:white;'>Doctor Panel</h3>");

            table5.AppendFormat(" </a>");
            PlaceHolder6.Controls.Add(new Literal { Text = table5.ToString() });

        }
    }
}

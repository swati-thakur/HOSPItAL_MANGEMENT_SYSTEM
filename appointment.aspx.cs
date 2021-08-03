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
    public partial class appointment : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        StringBuilder table1 = new StringBuilder();
        StringBuilder table2 = new StringBuilder();
        StringBuilder table3 = new StringBuilder();
        StringBuilder table4 = new StringBuilder();
        StringBuilder table5 = new StringBuilder();
        StringBuilder table6 = new StringBuilder();
        StringBuilder table7 = new StringBuilder();
        StringBuilder table8 = new StringBuilder();
        StringBuilder table9 = new StringBuilder();
        StringBuilder table10 = new StringBuilder();
        StringBuilder table11 = new StringBuilder();
        StringBuilder table13 = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");


            table.AppendFormat("<ul class='treeview-menu'>");

            table.AppendFormat("<li><a href='Doctor_list.aspx?id=" + Request.QueryString[0] + "'>Doctors List</a></li>");
            table.AppendFormat("<li><a href='add_doctor.aspx?id=" + Request.QueryString[0] + "'>Add Doctor</a></li>");
            table.AppendFormat("<li><a href='update_doctor.aspx?id=" + Request.QueryString[0] + "'>Update Doctor</a></li>");
            table.AppendFormat("<li><a href='approve_reject_doctor.aspx?id=" + Request.QueryString[0] + "'>Approve/Reject Doctor</a></li>");

            table.AppendFormat("</ul>");
            PlaceHolder2.Controls.Add(new Literal { Text = table.ToString() });





            table1.AppendFormat("<ul class='treeview-menu'>");

            table1.AppendFormat("<li><a href='Patient_list.aspx?id=" + Request.QueryString[0] + "'>Patients List</a></li>");
            table1.AppendFormat("<li><a href='add_patient.aspx?id=" + Request.QueryString[0] + "'>Add Patients</a></li>");
            table1.AppendFormat("<li><a href='update_patient.aspx?id=" + Request.QueryString[0] + "'>Update Patients</a></li>");
            table1.AppendFormat("<li><a href='patient_admit_form.aspx?id=" + Request.QueryString[0] + "'>Admitted Patients</a></li>");
            table1.AppendFormat("<li><a href='discharges_patient.aspx?id=" + Request.QueryString[0] + "'>Discharge Patients</a></li>");
            table1.AppendFormat("<li><a href='room_list.aspx?id=" + Request.QueryString[0] + "'>Room List</a></li>");


            table1.AppendFormat("</ul>");
            PlaceHolder3.Controls.Add(new Literal { Text = table1.ToString() });





            table2.AppendFormat("<ul class='treeview-menu'>");

            table2.AppendFormat("<li><a href='employee_list.aspx?id=" + Request.QueryString[0] + "'>Employee List</a></li>");
            table2.AppendFormat("<li><a href='add_employee.aspx?id=" + Request.QueryString[0] + "'>Add Employee</a></li>");
            table2.AppendFormat("<li><a href='update_employee.aspx?id=" + Request.QueryString[0] + "'>Update Employee</a></li>");

            table2.AppendFormat("</ul>");
            PlaceHolder4.Controls.Add(new Literal { Text = table2.ToString() });




            table3.AppendFormat("<ul class='treeview-menu'>");

            table3.AppendFormat("<li><a href='blood_stock_list.aspx?id=" + Request.QueryString[0] + "'>Stock List</a></li>");
            table3.AppendFormat("<li><a href='add_and_view_donor.aspx?id=" + Request.QueryString[0] + "'>Donor</a></li>");
            table3.AppendFormat("<li><a href='donate_form.aspx?id=" + Request.QueryString[0] + "'>Donate</a></li>");
            table3.AppendFormat("<li><a href='transfert_form.aspx?id=" + Request.QueryString[0] + "'>Transfert</a></li>");

            table3.AppendFormat("</ul>");
            PlaceHolder5.Controls.Add(new Literal { Text = table3.ToString() });





            table4.AppendFormat("<ul class='treeview-menu'>");

            table4.AppendFormat("<li><a href='Pharmacy_form.aspx?id=" + Request.QueryString[0] + "'>Add Stock</a></li>");
            table4.AppendFormat("<li><a href='update_pharmacy.aspx?id=" + Request.QueryString[0] + "'>Update stock</a></li>");

            table4.AppendFormat("</ul>");
            PlaceHolder6.Controls.Add(new Literal { Text = table4.ToString() });




            table5.AppendFormat("<ul class='treeview-menu'>");

            table5.AppendFormat("<li><a href='Add_test.aspx?id=" + Request.QueryString[0] + "'>Add Test</a></li>");
            table5.AppendFormat("<li><a href='update_test.aspx?id=" + Request.QueryString[0] + "'>Update Test</a></li>");
            table5.AppendFormat("<li><a href='Add_reports.aspx?id=" + Request.QueryString[0] + "'>Add Reports</a></li>");

            table5.AppendFormat("</ul>");
            PlaceHolder7.Controls.Add(new Literal { Text = table5.ToString() });




            table6.AppendFormat("<ul class='treeview-menu'>");

            table6.AppendFormat("<li><a href='appointment.aspx?id=" + Request.QueryString[0] + "'>Appointments List</a></li>");
            table6.AppendFormat("<li><a href='response_appointment.aspx?id=" + Request.QueryString[0] + "'>Response Appointment</a></li>");
            table6.AppendFormat("</ul>");
            PlaceHolder8.Controls.Add(new Literal { Text = table6.ToString() });




            table7.AppendFormat("<ul class='treeview-menu'>");

            table7.AppendFormat("<li><a href='leave_list.aspx?id=" + Request.QueryString[0] + "'>Leaves List</a></li>");

            table7.AppendFormat("</ul>");
            PlaceHolder9.Controls.Add(new Literal { Text = table7.ToString() });




            table8.AppendFormat("<ul class='treeview-menu'>");

            table8.AppendFormat("<li><a href='ambulance_details.aspx?id=" + Request.QueryString[0] + "'>Ambulance Details</a></li>");
            table8.AppendFormat("</ul>");
            PlaceHolder10.Controls.Add(new Literal { Text = table8.ToString() });




            table9.AppendFormat("<ul class='treeview-menu'>");

            table9.AppendFormat("<li><a href='salary_generate_form.aspx?id=" + Request.QueryString[0] + "'>Generate Salary</a></li>");
            table9.AppendFormat("</ul>");
            PlaceHolder11.Controls.Add(new Literal { Text = table9.ToString() });


            table10.AppendFormat("<ul class='treeview-menu'>");

            table10.AppendFormat("<li><a href='add_notice.aspx?id=" + Request.QueryString[0] + "'>Add notice</a></li>");
            table10.AppendFormat("</ul>");
            PlaceHolder12.Controls.Add(new Literal { Text = table10.ToString() });



            table13.AppendFormat("<a href='admin_dashboard.aspx?id=" + Request.QueryString[0] + "' class='logo'>");

            table13.AppendFormat("<h3 style='color:white;'>Admin Panel</h3>");

            table13.AppendFormat(" </a>");
            PlaceHolder13.Controls.Add(new Literal { Text = table13.ToString() });

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from online_appointment ORDER BY appointment_id DESC ", con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            table11.Append("<center><table style='width:1000px; heigth:auto;' class='table'>");
            table11.Append("<tr bgcolor='black'>");
             table11.Append("<th colspan='6'><center>APPOINTMENT LIST</center></h2></th>");
             table11.Append("</tr>");
             table11.Append("<tr>");
             table11.Append("<th bgcolor='#5DADE2'>APPOINTMENT ID</th>");
            table11.Append("<th bgcolor='#5DADE2'>FULL NAME</th>");
            table11.Append("<th bgcolor='#5DADE2'>EMAIL</th>");
            table11.Append("<th bgcolor='#5DADE2'>APPOINTMENT DATE</th>");
            table11.Append("<th bgcolor='#5DADE2'>MOBILE</th>");
            table11.Append("<th bgcolor='#5DADE2'>PROBLEM</th>");
         
            table11.Append("</tr>");
            if(dr1.HasRows)
            {
                while(dr1.Read())
                {
                     table11.Append("<tr>");
             table11.Append("<td>"+dr1[0]+"</td>");
             table11.Append("<td>"+dr1[1]+"</td>");
             table11.Append("<td>"+dr1[2]+"</td>");
             table11.Append("<td>"+dr1[3]+"</td>");
             table11.Append("<td>" + dr1[4] + "</td>");
             table11.Append("<td>" + dr1[5] + "</td>");
            

             table11.Append("</tr>");
                }
            }
            table11.Append("</center></table>");
            PlaceHolder1.Controls.Add(new Literal {Text=table11.ToString()});
            con.Close();
          

            
        }
    }
}
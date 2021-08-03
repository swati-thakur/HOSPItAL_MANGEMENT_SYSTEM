using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Hospital_Management_System
{
    public partial class admin_dashboard : System.Web.UI.Page
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

        private void Getdata()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from doctor", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Label1.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from patient", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Label2.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from employee", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Label3.Text = dt2.Rows[0][0].ToString();
            con.Close();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from online_appointment", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            Label4.Text = dt3.Rows[0][0].ToString();
            con.Close();

            con.Open();

            SqlCommand cd = new SqlCommand("select * from admin where id='" + Request.QueryString[0] + "' ", con);
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Label5.Text = Convert.ToString(dr["username"]);



            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Getdata();

           
            




            table.AppendFormat("<ul class='treeview-menu'>");

            table.AppendFormat("<li><a href='Doctor_list.aspx?id=" + Request.QueryString[0] + "'>Doctors List</a></li>");
            table.AppendFormat("<li><a href='add_doctor.aspx?id=" + Request.QueryString[0] + "'>Add Doctor</a></li>");
            table.AppendFormat("<li><a href='update_doctor.aspx?id=" + Request.QueryString[0] + "'>Update Doctor</a></li>");
            table.AppendFormat("<li><a href='approve_reject_doctor.aspx?id=" + Request.QueryString[0] + "'>Approve/Reject Doctor</a></li>");

            table.AppendFormat("</ul>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });




           
            table1.AppendFormat("<ul class='treeview-menu'>");

            table1.AppendFormat("<li><a href='Patient_list.aspx?id=" + Request.QueryString[0] + "'>Patients List</a></li>");
            table1.AppendFormat("<li><a href='add_patient.aspx?id=" + Request.QueryString[0] + "'>Add Patients</a></li>");
            table1.AppendFormat("<li><a href='update_patient.aspx?id=" + Request.QueryString[0] + "'>Update Patients</a></li>");
            table1.AppendFormat("<li><a href='patient_admit_form.aspx?id=" + Request.QueryString[0] + "'>Admitted Patients</a></li>");
            table1.AppendFormat("<li><a href='discharges_patient.aspx?id=" + Request.QueryString[0] + "'>Discharge Patients</a></li>");
            table1.AppendFormat("<li><a href='room_list.aspx?id=" + Request.QueryString[0] + "'>Room List</a></li>");


            table1.AppendFormat("</ul>");
            PlaceHolder2.Controls.Add(new Literal { Text = table1.ToString() });



           

            table2.AppendFormat("<ul class='treeview-menu'>");

            table2.AppendFormat("<li><a href='employee_list.aspx?id=" + Request.QueryString[0] + "'>Employee List</a></li>");
            table2.AppendFormat("<li><a href='add_employee.aspx?id=" + Request.QueryString[0] + "'>Add Employee</a></li>");
            table2.AppendFormat("<li><a href='update_employee.aspx?id=" + Request.QueryString[0] + "'>Update Employee</a></li>");

            table2.AppendFormat("</ul>");
            PlaceHolder3.Controls.Add(new Literal { Text = table2.ToString() });


        

            table3.AppendFormat("<ul class='treeview-menu'>");

            table3.AppendFormat("<li><a href='blood_stock_list.aspx?id=" + Request.QueryString[0] + "'>Stock List</a></li>");
            table3.AppendFormat("<li><a href='add_and_view_donor.aspx?id=" + Request.QueryString[0] + "'>Donor</a></li>");
            table3.AppendFormat("<li><a href='donate_form.aspx?id=" + Request.QueryString[0] + "'>Donate</a></li>");
            table3.AppendFormat("<li><a href='transfert_form.aspx?id=" + Request.QueryString[0] + "'>Transfert</a></li>");

            table3.AppendFormat("</ul>");
            PlaceHolder4.Controls.Add(new Literal { Text = table3.ToString() });




           
            table4.AppendFormat("<ul class='treeview-menu'>");

            table4.AppendFormat("<li><a href='Pharmacy_form.aspx?id=" + Request.QueryString[0] + "'>Add Stock</a></li>");
            table4.AppendFormat("<li><a href='update_pharmacy.aspx?id=" + Request.QueryString[0] + "'>Update stock</a></li>");

            table4.AppendFormat("</ul>");
            PlaceHolder5.Controls.Add(new Literal { Text = table4.ToString() });


         

            table5.AppendFormat("<ul class='treeview-menu'>");

            table5.AppendFormat("<li><a href='Add_test.aspx?id=" + Request.QueryString[0] + "'>Add Test</a></li>");
            table5.AppendFormat("<li><a href='update_test.aspx?id=" + Request.QueryString[0] + "'>Update Test</a></li>");
            table5.AppendFormat("<li><a href='Add_reports.aspx?id=" + Request.QueryString[0] + "'>Add Reports</a></li>");

            table5.AppendFormat("</ul>");
            PlaceHolder6.Controls.Add(new Literal { Text = table5.ToString() });

          


            table6.AppendFormat("<ul class='treeview-menu'>");

            table6.AppendFormat("<li><a href='appointment.aspx?id=" + Request.QueryString[0] + "'>Appointments List</a></li>");
            table6.AppendFormat("<li><a href='response_appointment.aspx?id=" + Request.QueryString[0] + "'>Response Appointment</a></li>");
            table6.AppendFormat("</ul>");
            PlaceHolder7.Controls.Add(new Literal { Text = table6.ToString() });


            
                    
            table7.AppendFormat("<ul class='treeview-menu'>");

            table7.AppendFormat("<li><a href='leave_list.aspx?id=" + Request.QueryString[0] + "'>Leaves List</a></li>");

            table7.AppendFormat("</ul>");
            PlaceHolder8.Controls.Add(new Literal { Text = table7.ToString() });


           

            table8.AppendFormat("<ul class='treeview-menu'>");

            table8.AppendFormat("<li><a href='ambulance_details.aspx?id=" + Request.QueryString[0] + "'>Ambulance Details</a></li>");
            table8.AppendFormat("</ul>");
            PlaceHolder9.Controls.Add(new Literal { Text = table8.ToString() });



           
            table9.AppendFormat("<ul class='treeview-menu'>");

            table9.AppendFormat("<li><a href='salary_generate_form.aspx?id=" + Request.QueryString[0] + "'>Generate Salary</a></li>");
            table9.AppendFormat("</ul>");
            PlaceHolder10.Controls.Add(new Literal { Text = table9.ToString() });

           
            table10.AppendFormat("<ul class='treeview-menu'>");

            table10.AppendFormat("<li><a href='add_notice.aspx?id=" + Request.QueryString[0] + "'>Add notice</a></li>");
            table10.AppendFormat("</ul>");
            PlaceHolder11.Controls.Add(new Literal { Text = table10.ToString() });




            table11.AppendFormat("<a href='admin_dashboard.aspx?id=" + Request.QueryString[0] + "' class='logo'>");

            table11.AppendFormat("<h3 style='color:white;'>Admin Panel</h3>");

            table11.AppendFormat(" </a>");
            PlaceHolder12.Controls.Add(new Literal { Text = table11.ToString() });

        }
    }
}
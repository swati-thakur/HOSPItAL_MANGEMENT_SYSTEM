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
    public partial class add_patient : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");

            con.Open();




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

        protected void Button2_Click(object sender, EventArgs e)
        {
            string iid;
            string qy = "select patient_id from patient order by patient_id Desc";
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
            con.Close();
            String registeration_date = DateTime.Now.ToString("MM/dd/yyyy");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into patient(patient_id,name,age,blood_group,mobile,email,address,disease,password,registeration_date) values('" + idd + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.SelectedItem.ToString() + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "', '" + registeration_date + "')", con);
            int query = cmd.ExecuteNonQuery();
            if (query > 0)
            {
                Label1.Visible = true;
                Label1.Text = "Patient add successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";

            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";


            }

            con.Close();

        }
    }
}
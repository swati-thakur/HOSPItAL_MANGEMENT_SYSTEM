﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class delete_employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString[0];

            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Hospital_management_system;Integrated Security=True");
            con.Open();
            SqlCommand cd = new SqlCommand("delete from employee where employee_id='" + Label1.Text + "' ", con);
            SqlDataReader dr = cd.ExecuteReader();
            Response.Redirect("update_employee.aspx?id="+Request.QueryString[1]+"");

        }
    }
}
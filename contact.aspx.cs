using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Hospital_Management_System
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static String to;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != "")
            {

                String from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = (TextBox2.Text).ToString();
                from = "thakurangel12345@gmail.com";
                pass = "AngelThakur!9";
                messageBody = "Thank for contacting us, ww will soon respond your mail";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Contact feedback";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                Label1.Visible = true;
                Label1.Text = "successfully mail";

                try
                {
                    smtp.Send(message);

                }
                catch (Exception ex)
                {
                    Label1.Visible = true;
                    Label1.Text = ex.Message;
                }
            }

            if (Label1.Text == "successfully mail")
            {
                string iid;
                string qy = "select id from contact order by id Desc";
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
                String date_of_contact = DateTime.Now.ToString("MM/dd/yyyy");


                con.Open();
                SqlCommand cmd = new SqlCommand("insert into contact(id,full_name,mail,subject,message,date_of_contact) values('" + idd + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + date_of_contact + "')", con);
                int query = cmd.ExecuteNonQuery();
                if (query > 0)
                {
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
             
              
                con.Close();
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Try Again";
            }
        }
    }
}

          

            
      
  


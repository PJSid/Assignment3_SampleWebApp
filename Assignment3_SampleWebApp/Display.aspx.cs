using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3_SampleWebApp
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            print();
        }

        public void print()
        {
            FNameDisplay.Text = Session["fname"].ToString();
            LNameDisplay.Text = Session["lname"].ToString();
            EmailDisplay.Text = Session["email"].ToString();
            PasswordDisplay.Text = Session["password"].ToString();
            CPasswordDisplay.Text = Session["cpassword"].ToString();
            PhoneNumberLabel.Text = Session["phonenumber"].ToString();

        }




        //    string Text = "The following user is trying to register into our application:\n" +"id: "+ Session["id"].ToString() +"\n"+
        //                                                "FirstNme: "+ Session["fname"].ToString() + "\n" +
        //                                                "LastName: "+ Session["lname"].ToString() + "\n" +
        //                                                "Email: " + Session["email"].ToString() + "\n" +
        //                                                  "PhoneNUmber: " + Session["phonenumber"].ToString(); 

        //     Label1.Text = Text;
        //}
    

        public void Button1_Click(object sender, EventArgs e)
        {
            string id = Session["id"].ToString();
            string fname = Session["fname"].ToString();
            string lname = Session["lname"].ToString();
            string email = Session["email"].ToString();
            string password = Session["password"].ToString();
            string cpassword = Session["cpassword"].ToString();
            string phonenumber = Session["phonenumber"].ToString();
            DateTime date = DateTime.Now;
            execution(Convert.ToInt32(id), fname, lname, email, password, cpassword, phonenumber, date);
        }

        public string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["ASPNETWebFormAssignmentConnectionString"].ConnectionString;
        }


        public void execution(int id, string fname, string lname, string email, string password, string confirmPassword, string phoneNumber, DateTime date)
        {



            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO RegistrationForm2 (ID, FirstName, LastName, Email, Password, ConfirmPassword, PhoneNumber, Date) VALUES" + "(@ID, @fname, @lname, @email, @password, @confirmPassword, @phoneNumber, @date)";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] parm = new SqlParameter[8];
                parm[0] = new SqlParameter("@id", SqlDbType.Int, 18);
                parm[1] = new SqlParameter("@fname", SqlDbType.NChar, 10);
                parm[2] = new SqlParameter("@lname", SqlDbType.NChar, 10);
                parm[3] = new SqlParameter("@email", SqlDbType.NChar, 10);
                parm[4] = new SqlParameter("@Password", SqlDbType.NChar, 10);
                parm[5] = new SqlParameter("@confirmPassword", SqlDbType.NChar, 10);
                parm[6] = new SqlParameter("@phoneNumber", SqlDbType.NChar, 10);
                parm[7] = new SqlParameter("@date", SqlDbType.DateTime, 10);

                parm[0].Value = id;
                parm[1].Value = fname;
                parm[2].Value = lname;
                parm[3].Value = email;
                parm[4].Value = password;
                parm[5].Value = confirmPassword;
                parm[6].Value = phoneNumber;
                parm[7].Value = date;

                for (int i = 0; i < parm.Length; i++)
                {
                    cmd.Parameters.Add(parm[i]);
                }

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                ConfirmData.Text = "Data Record Saved. Thank you for your application";
            
                

            }
            catch (System.Data.SqlClient.SqlException e)
            {
                string msg = "Error occured at db operation(insert)";
                msg += e.Message;
                throw new Exception(msg);

            }

            finally
            {
                con.Close();
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["id"] = FNameDisplay.Text;
            Session["fname"] = LNameDisplay.Text;
            Session["lname"] = EmailDisplay.Text;
            Session["password"] = PasswordDisplay.Text;
            Session["cpassword"] = CPasswordDisplay.Text;
            Session["phonenumber"] = PhoneNumberLabel.Text;
            Server.Transfer("~/Registration.aspx");
        }
        }
}
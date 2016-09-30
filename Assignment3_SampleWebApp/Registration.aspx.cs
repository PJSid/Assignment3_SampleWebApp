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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    id.Text = Session["id"].ToString();
            //    fname.Text = Session["fname"].ToString();
            //    lname.Text = Session["lname"].ToString();
            //    email.Text = Session["email"].ToString();
            //    password1.Text = Session["password"].ToString();
            //    password2.Text = Session["cpassword"].ToString();
            //    phonenumber.Text = Session["phonenumber"].ToString();
            //}


            Page previouspage = Page.PreviousPage;

            if (previouspage != null)
            {
                id.Text = Session["id"].ToString();
                fname.Text = Session["fname"].ToString();
                lname.Text = Session["lname"].ToString();
                email.Text = Session["email"].ToString();
                password1.Text = Session["password"].ToString();
                password2.Text = Session["cpassword"].ToString();
                phonenumber.Text = Session["phonenumber"].ToString();


                //fname.Text = ((Label)previouspage.FindControl("FNameDisplay")).Text;
                //lname.Text = ((Label)previouspage.FindControl("LNameDisplay")).Text;
                //email.Text = ((Label)previouspage.FindControl("EmailDisplay")).Text;
                //password1.Text = ((Label)previouspage.FindControl("PasswordDisplay")).Text;
                //password2.Text = ((Label)previouspage.FindControl("CPasswordDisplay")).Text;
                //phonenumber.Text = ((Label)previouspage.FindControl("phonenumber")).Text;
            }

        }


        protected void Submit_Click(object sender, EventArgs e)
        {
            Session["id"] = id.Text;
            Session["fname"] = fname.Text;
            Session["lname"] = lname.Text;
            Session["email"] = email.Text;
            Session["password"] = password1.Text;
            Session["cpassword"] = password2.Text;
            Session["phonenumber"] = phonenumber.Text;

            Server.Transfer("~/Display.aspx");


            //execution(Convert.ToInt32(id.Text), fname.Text,lname.Text,email.Text,password1.Text,password2.Text,phonenumber.Text,DateTime.Now);
        }
    

        //public string GetConnectionString()
        //{
        //    return System.Configuration.ConfigurationManager.ConnectionStrings["ASPNETWebFormAssignmentConnectionString"].ConnectionString;
        //}


        //public void execution(int ID, string fname, string lname, string email, string password, string confirmPassword, string phoneNumber, DateTime date )
        //{



        //    SqlConnection con = new SqlConnection(GetConnectionString());
        //    string sql ="INSERT INTO RegistrationForm2 (ID, FirstName, LastName, Email, Password, ConfirmPassword, PhoneNumber, Date) VALUES"+"(@ID, @fname, @lname, @email, @password, @confirmPassword, @phoneNumber, @date)";

        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        SqlParameter[] parm = new SqlParameter[8];
        //        parm[0] = new SqlParameter("@ID", SqlDbType.Int, 18);
        //        parm[1] = new SqlParameter("@fname", SqlDbType.NChar, 10);
        //        parm[2] = new SqlParameter("@lname", SqlDbType.NChar, 10);
        //        parm[3] = new SqlParameter("@email", SqlDbType.NChar, 10);
        //        parm[4] = new SqlParameter("@Password", SqlDbType.NChar, 10);
        //        parm[5] = new SqlParameter("@confirmPassword", SqlDbType.NChar, 10);
        //        parm[6] = new SqlParameter("@phoneNumber", SqlDbType.NChar, 10);
        //        parm[7] = new SqlParameter("@date", SqlDbType.DateTime, 10);

        //        parm[0].Value = ID;
        //        parm[1].Value = fname;
        //        parm[2].Value = lname;
        //        parm[3].Value = email;
        //        parm[4].Value = password;
        //        parm[5].Value = confirmPassword;
        //        parm[6].Value = phoneNumber;
        //        parm[7].Value = date;

        //        for(int i=0; i<parm.Length;i++)
        //        {
        //            cmd.Parameters.Add(parm[i]);
        //        }

        //        cmd.CommandType = CommandType.Text;
        //        cmd.ExecuteNonQuery();

        //    } catch(System.Data.SqlClient.SqlException e)
        //    {
        //        string msg = "Error occured at db operation(insert)";
        //        msg += e.Message;
        //        throw new Exception(msg);

        //    }

        //    finally
        //    {
        //        con.Close();
        //    }

            

        //}

        protected void PhoneNumberCustomerValidator_ServerValidate(object source, ServerValidateEventArgs e)
        {
            if (e.Value.Length == 10)
                e.IsValid = true;
            else
                e.IsValid = false;
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.DataBase;
using TogetherCulture.Session;

namespace TogetherCulture
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
        private mainDisplay FindMainDisplay()
        {
            Control parent = this.Parent;
            while (parent != null && !(parent is mainDisplay))
            {
                parent = parent.Parent;
            }
            return parent as mainDisplay;
        }

        public void SwitchToUserControl(Type controlType)
        {
            mainDisplay mainDisplay = FindMainDisplay();
            if (mainDisplay != null)
            {
                UserControl newControl = (UserControl)Activator.CreateInstance(controlType);
                mainDisplay.LoadUserControl(newControl);
            }
            else
            {
                MessageBox.Show("MainDisplay form not found!");
            }
        }
        private void reg1_Click(object sender, EventArgs e)
        {
            SwitchToUserControl(typeof(RegisterControl));
        }

        private void login1_Click(object sender, EventArgs e)
        {
            if (email.Text != "" && pass.Text != "")
            {
                string hashpass = Hash.Hash.ComputeSha256Hash(pass.Text);
                string query = "select * from users where email = '"+email.Text+"' and password = '"+hashpass+"'";
                DataTable data = DBSingleton.Instance.ExecuteQuery(query);
                string typeuser = "";
                string stus = "";
                string fnm = ""; string lnm = ""; string eml = ""; int id=0;
                foreach (DataRow row in data.Rows)
                {
                    typeuser = row["user_type"].ToString();
                    stus = row["status"].ToString();
                    fnm = row["first_name"].ToString();
                    lnm = row["last_name"].ToString();
                    eml = row["email"].ToString();
                    id = Convert.ToInt32(row["user_id"]);
                }
                if (typeuser == "Member" || typeuser == "Administrator")
                {
                    if (stus == "Pending")
                    {
                        err.Text = "Your Account is in pending state";
                    }
                    else if (stus == "Suspended")
                    {
                        err.Text = "Your Account is Suspended! Please contact Admin.";
                    }
                    else
                    {
                        err.Text = "Log";
                        SessionSingleton.Instance.email = eml;
                        SessionSingleton.Instance.firstname = fnm;
                        SessionSingleton.Instance.lastname = lnm;
                        SessionSingleton.Instance.user_id = id;
                        SessionSingleton.Instance.user_type = typeuser;
                        if (typeuser == "Member")
                        {
                            SwitchToUserControl(typeof(MemberControl));
                        }
                        else
                        {
                            SwitchToUserControl(typeof(AdminControl));
                        }
                    }
                }
                else if(typeuser == "")
                {
                    err.Text = "No User Account Found! Please Register.";
                }
                else
                {
                    err.Text = "Sorry! But you are not a member yet.";
                }
            }
            else
            {
                err.Text = "Please Fill all Fields";
            }
        }
    }
}

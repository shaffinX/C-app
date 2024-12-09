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

namespace TogetherCulture
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
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

        private void log1_Click(object sender, EventArgs e)
        {
            SwitchToUserControl(typeof(LoginControl));
        }

        private void register1_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" && lname.Text != "" && email.Text != "" && pass.Text != "" && interest1.Text !="" && checkedListBox1.Text!="")
            {
                if (pass.Text.Length >= 8)
                {
                    string hashpass = Hash.Hash.ComputeSha256Hash(pass.Text);
                    string memty = checkedListBox1.Text;
                    string query = $@"
                    WITH inserted_user AS (
                        INSERT INTO users (first_name, last_name, email, password, user_type)
                        VALUES ('{fname.Text}', '{lname.Text}', '{email.Text}', '{hashpass}', 'NonMember')
                        RETURNING user_id
                    )
                    INSERT INTO memberships (user_id, membership_type, interests)
                    SELECT user_id, '{memty}', '{interest1.Text}' FROM inserted_user;";
                    if (DBSingleton.Instance.ExecuteUpdate(query))
                    {
                        MessageBox.Show("You Have Been Registered");
                        SwitchToUserControl(typeof(LoginControl));
                    }
                    else
                    {
                        err.Text = "There is already an account!";
                    }
                }
                else
                {
                    err.Text = "Password must be atleast 8 characters long";
                }
            }
            else
            {
                err.Text = "Please Fill all the input Fields";
            }
        }
    }
}

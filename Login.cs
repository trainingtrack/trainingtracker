using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class frmLogin : Form
    {
        public static string userLogin = "User1";
        public static string userPass = "pass1";
        public static string adminPass = "admin1";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (tbxUser.Text.Equals(userLogin))
                {
                    if (tbxPassword.Text.Equals(userPass))
                    {
                        UserLanding newLand = new UserLanding();
                        newLand.Show();
                    }
                    if (tbxPassword.Text.Equals(adminPass))
                    {
                        AdminLanding newLand = new AdminLanding();
                        newLand.Show();
                    }
                }
            }
        }

        private void tbxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (tbxUser.Text.Equals(userLogin))
                {
                    if (tbxPassword.Text.Equals(userPass))
                    {
                        UserLanding newLand = new UserLanding();
                        newLand.Show();
                    }
                    if (tbxPassword.Text.Equals(adminPass))
                    {
                        AdminLanding newLand = new AdminLanding();
                        newLand.Show();
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmSignIn : Form
    {
        UserManagement userManagement = new UserManagement();
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserName = txt_userName.Text,
                PassWord = txt_password.Text
            };
            if (userManagement.loginUser(user))
            {
                FrmFoodManagement frmMain = new FrmFoodManagement();
                frmMain.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }


        }
            
        

        private void FrmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_navigateRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();

        }

        private void txt_userName_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_userName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_userName, "Username is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_userName, null);
                e.Cancel = false;
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
           
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_password, "Password is not left blank!");
            }
            else if (txt_password.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_password, "at least 6 characters");

            }
            else
            {
                errorProvider1.SetError(txt_password, null);
                e.Cancel = false;
            }
        }
    }
}

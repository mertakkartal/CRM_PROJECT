using CRM_Project.DAL.Context;
using CRM_Project.DAL.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CRM_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Login Enteredlogin { get; set; }
        public int LoginId { get; set; }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SaveLogin();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveLogin()
        {
            using (CRMContext DB = new CRMContext())
            {
                try
                {
                    if (this.LoginId > 0)
                    {
                        this.Enteredlogin = DB.logins.FirstOrDefault(t0 => t0.ID == this.LoginId);
                        MessageBox.Show("Login Succesfull");
                    }
                    else
                    {
                        Enteredlogin = new Login
                        {
                        };
                        DB.logins.Add(this.Enteredlogin);
                    }
                    this.Enteredlogin.Username = usernameTextBox.Text;
                    this.Enteredlogin.Password = passwordMaskedTextBox.Text;
                    DB.SaveChanges();
                    this.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
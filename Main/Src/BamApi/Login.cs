﻿using System.Windows.Forms;

namespace BamApi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string UserName
        {

            get
            {
                return txtUsername.Text;
            }
        }

        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckValues();
            }
        }

        private void CheckValues()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            CheckValues();
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckValues();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;

namespace FCM.Applications.Client
{
    partial class LoginForm : Form
    {
        void InitializeComponent()
        {
            ClientSize = new Size(300, 135);
            Title = "Client Login";
            Padding = new Padding(10, 10, 10, 10);

            Content = new DynamicLayout
            {
                Rows =
                {
                    new Label { ID = "UsernameLabel", Text = "Username:" },
                    new TextBox { ID = "UsernameTextBox" },
                    new Label { },
                    new Label { ID = "PasswordLabel", Text = "Password:" },
                    new PasswordBox { ID = "PasswordTextBox" },

                    new Button { ID = "LoginButton", Text = "Login" }
                }
            };
        }
    }
}

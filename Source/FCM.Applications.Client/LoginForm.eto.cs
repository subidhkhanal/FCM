using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;

namespace FCM.Applications.Client
{
    partial class LoginForm : Form
    {
        private PixelLayout Layout = new PixelLayout();

        void InitializeComponent()
        {
            //
            // usernameLabel
            //
            usernameLabel = new Label
            {
                ID = "usernameLabel",
                Size = new Size(58, 13),
                Text = "Username:"
            };
            //
            // passwordLabel
            //
            passwordLabel = new Label
            {
                ID = "passwordLabel",
                Size = new Size(56, 13),
                Text = "Password:"
            };
            //
            // domainLabel
            //
            domainLabel = new Label
            {
                ID = "domainLabel",
                Size = new Size(46, 13),
                Text = "Domain:"
            };
            //
            // usernameTextBox
            //
            usernameTextBox = new TextBox
            {
                ID = "usernameTextBox",
                Size = new Size(253, 20)
            };
            //
            // passwordPasswordBox
            //
            passwordPasswordBox = new PasswordBox
            {
                ID = "passwordPasswordBox",
                Size = new Size(253, 20)
            };
            //
            // domainComboBox
            //
            domainComboBox = new ComboBox
            {
                ID = "domainComboBox",
                Size = new Size(253, 21)
            };
            //
            // headerImageView
            //
            headerImageView = new ImageView
            {
                ID = "headerImageView",
                Size = new Size(341, 50)
            };
            //
            // loginProgressBar
            //
            loginProgressBar = new ProgressBar
            {
                ID = "loginProgressBar",
                Size = new Size(341, 10)
            };
            //
            // loginButton
            //
            loginButton = new Button
            {
                ID = "cancelButton",
                Size = new Size(75, 23),
                Text = "Login"
            };
            //
            // cancelButton
            //
            cancelButton = new Button
            {
                ID = "cancelButton",
                Size = new Size(75, 23),
                Text = "Cancel"
            };
            //
            // optionsButton
            //
            optionsButton = new Button
            {
                Enabled = false,
                ID = "optionButton",
                Size = new Size(100, 23),
                Text = "Hide Options" // Will change from "Show Otions" to "Hide Options".
            };
            // LoginForm
            ClientSize = new Size(341, 209);
            ID = "LoginForm";
            Maximizable = false;
            Resizable = false;
            Title = "Client Login";
            Layout.Add(usernameLabel, 12, 78);
            Layout.Add(passwordLabel, 12, 104);
            Layout.Add(domainLabel, 12, 140);
            Layout.Add(usernameTextBox, 76, 75);
            Layout.Add(passwordPasswordBox, 76, 101);
            Layout.Add(domainComboBox, 76, 137);
            Layout.Add(loginButton, 254, 174);
            Layout.Add(cancelButton, 173, 174);
            Layout.Add(optionsButton, 12, 174);
            Layout.Add(loginProgressBar, 0, 50);
            Layout.Add(headerImageView, 0, 0);
            Content = Layout;
        }

        private Label usernameLabel;
        private Label passwordLabel;
        private Label domainLabel;
        private TextBox usernameTextBox;
        private PasswordBox passwordPasswordBox;
        private ComboBox domainComboBox;
        private ImageView headerImageView;
        private ProgressBar loginProgressBar;
        private Button loginButton;
        private Button cancelButton;
        private Button optionsButton;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FVES_Interface
{
    public partial class Login : Form
    {
        public Point mouseLocation;
        public Point lastLocation;
        private bool mouseDown;
        bool flag = true;
        bool flag2 = true;
        Form1 form = new Form1();
        public static string CurrentUser;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                ((Form)this.TopLevelControl).Location = new Point(
                    (((Form)this.TopLevelControl).Location.X - lastLocation.X) + e.X, (((Form)this.TopLevelControl).Location.Y - lastLocation.Y) + e.Y);

                ((Form)this.TopLevelControl).Update();
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            
            if (Username_textbox.Text != "asma")
                InputError.SetError(panel1, "Invalid User!");
            else
                InputError.SetError(panel1, "");

            if (Password_textbox.Text != "123")
                InputError.SetError(panel2, "Incorrect Password!");
            else
                InputError.SetError(panel2, "");

            if (Username_textbox.Text == "asma" && Password_textbox.Text == "123")
                form.Show();


            InputError.SetIconPadding(panel1, 5);
            InputError.SetIconPadding(panel2, 5);
        }

        private void Username_textbox_Enter(object sender, EventArgs e)
        {
            if (flag.Equals(true))
                Username_textbox.Text = "";
            Username_textbox.ForeColor = Color.FromArgb(50, 41, 47);
            flag = false;
        }

        private void Password_textbox_Enter(object sender, EventArgs e)
        {
            if (flag2.Equals(true))
                Password_textbox.Text = "";
            Password_textbox.ForeColor = Color.FromArgb(50, 41, 47);
            flag2 = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmationMessage confirm = new ConfirmationMessage();

            confirm.label1.Text = "Are you sure you want to exit?";
            confirm.label2.Visible = false;
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }
    }
}

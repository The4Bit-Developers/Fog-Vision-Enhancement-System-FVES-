using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FVES_Interface
{
    public partial class Form1 : Form
    {
        bool Image_Validation;
        RepForm rep = new RepForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rep.Show();

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //CurrentUser_lbl.Text = Login.CurrentUser;
            CurrentUser_lbl.Text = "asma";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime_lbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfirmationMessage confirm = new ConfirmationMessage();

            confirm.label1.Text = "Are you sure you want to exit?";
            confirm.label2.Visible = false;
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Logout = new Login();
            ConfirmationMessage confirm = new  ConfirmationMessage();
               
                confirm.label1.Text = "Are you sure you want to logout?";
                confirm.label2.Visible = false;
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    Logout.Show();
                }
           // DialogResult k;
            //k = MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message.", MessageBoxButtons.YesNo);
            //if (k == System.Windows.Forms.DialogResult.Yes)
            //{
            //    this.Hide();
            //    Login Log = new Login();
            //    Log.Show();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath_lbl.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                FileName_lbl.Text = FilePath_lbl.Text.Substring(FilePath_lbl.Text.LastIndexOf('\\') + 1);
                Main_Picture.SizeMode = PictureBoxSizeMode.Zoom;
                Main_Picture.Image = new Bitmap(FilePath_lbl.Text);
                Status_lbl.Text = "Image opened";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ImageInputError();
            if (Image_Validation.Equals(true))
            {
                Processing Process = new Processing();
                Process.Show();
            }
        }

        private void ImageInputError()
        {
            if (FilePath_lbl.Text.Equals("*browse image*"))
            {
                SuccessfulMessage success = new SuccessfulMessage();
                success.MessageBar.Text = "Error Message.";
                success.label1.Text = "Must browse an image!";
                success.panel3.Size = new Size (115,3);
                if (success.ShowDialog() == DialogResult.OK)
                    success.Close();
            }
            else
                Image_Validation = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ImageInputError();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ImageInputError();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ImageInputError();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ImageInputError();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ImageInputError();
            if (Image_Validation.Equals(true))
            {
                ConfirmationMessage confirm = new ConfirmationMessage();
                if (confirm.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Feature not yet available\n We're working on it!","Ooops");
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Picture.Image = new Bitmap(FVES_Interface.Properties.Resources.Initial_Image);
            Main_Picture.SizeMode = PictureBoxSizeMode.CenterImage;
            FilePath_lbl.Text = "*browse image*";
            FileName_lbl.Text = "*filenamehere*";
            Status_lbl.Text = "Image Cleared";
            Image_Validation = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageInputError();
            if (Image_Validation.Equals(true))
            {
                savefile.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(savefile.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    Main_Picture.Image.Save(savefile.FileName, format);

                    SuccessfulMessage success = new SuccessfulMessage();
                    success.label1.Text = "Image saved successfully!";
                    if (success.ShowDialog() == DialogResult.OK)
                        Status_lbl.Text = "Image Saved";
                }
            }
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

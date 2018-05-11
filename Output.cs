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
    public partial class Output : Form
    {
        Form1 Workspace = new Form1();
        public Output()
        {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e)
        {
            Output_Picture.Image = new Bitmap(FVES_Interface.Properties.Resources.UBIT1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ConfirmationMessage confirm = new ConfirmationMessage();
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                Workspace.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmationMessage confirm = new ConfirmationMessage();
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                Workspace.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
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
                Output_Picture.Image.Save(savefile.FileName, format);

                SuccessfulMessage success = new SuccessfulMessage();
                success.label1.Text = "Image saved successfully!";
                if (success.ShowDialog() == DialogResult.OK)
                    label5.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myform = new Form1();
            myform.Show();
        }
    }
}

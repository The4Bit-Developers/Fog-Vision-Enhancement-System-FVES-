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
    public partial class Processing : Form
    {

        public Processing()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                SuccessfulMessage success = new SuccessfulMessage();
                
                this.Close();
                if(success.ShowDialog()==DialogResult.OK)
                {
                    Output Output_form = new Output();
                    Output_form.Show();
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "Output")
                            Application.OpenForms[i].Hide();
                    }
                }

            }
        }

        private void Processing_Load(object sender, EventArgs e)
        {

        }
    }
}

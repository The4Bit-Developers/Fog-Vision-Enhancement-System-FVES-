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
    public partial class SuccessfulMessage : Form
    {
       // public System.Windows.Forms.Label MessageBar;
        public SuccessfulMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SuccessfulMessage_Load(object sender, EventArgs e)
        {

        }


    }
}

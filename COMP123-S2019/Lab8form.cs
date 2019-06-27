using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019
{
    public partial class Lab8 : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        //this is the constructor for lab 8 form
        public Lab8()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //this is the event handler for submitbutton
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = nametextbox.Text;
            UserAge = float.Parse(agetextbox.Text);
            Outputlable.Text = nametextbox.Text + " " + agetextbox.Text;
            nametextbox.Text = string.Empty;
            agetextbox.Text = string.Empty;
        }

        //this is the event handler for lab8 load event
        private void Lab8_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }

        private void agetextbox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaChimpDataJamWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Observer_Click(object sender, EventArgs e)
        {
           
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateEntry createentry = new CreateEntry();
            createentry.Show();
        }
    }
}

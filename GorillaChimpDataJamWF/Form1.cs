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
        //private dictionary object string string selected search fields  then set = to new on form load.  Then attach cchange events to all of those fields that
        //check for existence of key and if does not exist add key and value, else update value.  key is name of column; value is value and throw in there. 
        //Dataset not bound. 
        private Dictionary<string, string> selectedsearchfields;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            selectedsearchfields = new Dictionary<string, string>();
            

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


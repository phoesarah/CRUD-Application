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
        Gorillas2Entities1 db = new Gorillas2Entities1();
        public Form1()
        {
            InitializeComponent();
            BeginDate.Hide();
            datelabel.Hide();
            EndDate.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            selectedsearchfields = new Dictionary<string, string>();
            
            
        }

       

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateEntry createentry = new CreateEntry();
            createentry.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Observer_Changed(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("Observer"))
            {
                selectedsearchfields["Observer"] = ObserverCombo.SelectedValue.ToString();
            }
            else
            {
                selectedsearchfields.Add("Observer",  ((ComboBox)sender).Text);
                
            }
        }

        private void SpeciesChanged(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("Species"))
            {
                selectedsearchfields["Species"] = SpeciesCombo.SelectedValue.ToString();
            }
            else
            {
                selectedsearchfields.Add("Species", ((ComboBox)sender).Text);

            }
        }

        private void LocationChanged(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("Location"))
            {
                selectedsearchfields["Location"] = LocationCombo.SelectedValue.ToString();
            }
            else
            {
                selectedsearchfields.Add("Location", ((ComboBox)sender).Text);

            }
        }

        private void PartySizeChanged(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("PartySize"))
            {
                selectedsearchfields["PartySize"] = PartySizeCombo.SelectedValue.ToString();
            }
            else
            {
                selectedsearchfields.Add("PartySize", ((ComboBox)sender).Text);

            }
        }

        private void GroupIDChanged(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("GroupID"))
            {
                selectedsearchfields["GroupID"] = GroupIDBox.SelectedValue.ToString();
            }
            else
            {
                selectedsearchfields.Add("GroupID", ((ComboBox)sender).Text);

            }
        }

        private void CommentChanged(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("Comment"))
            {
                selectedsearchfields["Comment"] = CommentBox.Text;
            }
            else
            {
                selectedsearchfields.Add("Comment", CommentBox.Text);

            }
        }

        private void BeginDateChanged(object sender, EventArgs e)
        {

        }

        private void EndDateChanged(object sender, EventArgs e)
        {

        }

        private void CheckforDateCheckBoxClicked(object sender, EventArgs e)
        {
            if (checkForDateCheckbox.Checked)
            {
                BeginDate.Show();
                datelabel.Show();
                EndDate.Show();
            }
            if (!checkForDateCheckbox.Checked)
            {
                BeginDate.Hide();
                datelabel.Hide();
                EndDate.Hide();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = db.HabEncounters.Where(x => x.OBSERVER == selectedsearchfields["Observer"].ToString()).ToList();
        }

        private void habEncounterBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

         
       

        }
    }


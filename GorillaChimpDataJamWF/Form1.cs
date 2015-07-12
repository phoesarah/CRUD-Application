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
        DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
        DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();

        public Form1()
        {
            InitializeComponent();
            BeginDate.Hide();
            datelabel.Hide();
            EndDate.Hide();
            checkForDateCheckbox.Hide();


            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "EDIT"; Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            dataGridView1.Columns.Add(Editlink);

            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "DELETE";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete"; dataGridView1.Columns.Add(Deletelink);

            
            
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
                selectedsearchfields.Remove("Observer");
                selectedsearchfields.Add("Observer", ((ComboBox)sender).Text);
                
               
                
                // selectedsearchfields["Observer"] = ((ComboBox)sender).SelectedItem.ToString();
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
                
                selectedsearchfields["Species"] = ((ComboBox)sender).SelectedItem.ToString();
            }
            else
            {
               
                selectedsearchfields.Add("Species", ((ComboBox)sender).Text);

            }
        }

        private void locationboxchanged(object sender, EventArgs e)
        {
            if (selectedsearchfields.Keys.Contains("Location"))
            {
               
                selectedsearchfields["Location"] = ((ComboBox)sender).SelectedItem.ToString();
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
              
                selectedsearchfields["PartySize"] = ((ComboBox)sender).SelectedItem.ToString();
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
          
                selectedsearchfields["GroupID"] = ((ComboBox)sender).SelectedItem.ToString();
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
             
                selectedsearchfields["Comment"] = ((RichTextBox)sender).Text;
            }
            else
            {
            
                selectedsearchfields.Add("Comment", ((RichTextBox)sender).Text);

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
            var habdatacon = db.HabEncounters.ToList();
            foreach (var key in selectedsearchfields.Keys)
            {
                var val = selectedsearchfields[key];
                switch (key)
                {
                    case "Observer":
                        if (val != null)
                            habdatacon = habdatacon.Where(x => x.OBSERVER == val).ToList();
                        break;
                    case "Species":
                        if (val != null)
                            habdatacon = habdatacon.Where(x => x.SPECIES == val).ToList();
                        break;

                    case "Location":
                        if (val != null)
                            habdatacon = habdatacon.Where(x => x.INITIAL_LOCATION == val).ToList();
                        break;

                    case "PartySize":
                        if (val != null)
                            habdatacon = habdatacon.Where(x => x.C_ORIGINAL_PARTY_SIZE_ == val).ToList();
                        break;

                    case "GroupID":
                        if (val != null)
                            habdatacon = habdatacon.Where(x => x.GROUP_ID == val).ToList();
                        break;

                    case "Comment":
                        if (val != null)
                             habdatacon = habdatacon.Where(x => x.COMMENTS.Contains(val)).ToList();
                            break;
                   
                }
            }


            dataGridView1.DataSource = habdatacon;

         
           

            if (habdatacon.Count == 0)
            {
                MessageBox.Show("Sorry, no results match your query", "OK");
            }
            //dataGridView1.DataSource = db.HabEncounters.Where(x => x.SPECIES == "gorilla").ToList();
            //selectedsearchfields["Observer"].ToString()).ToList();
        }

        private void habEncounterBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            selectedsearchfields.Clear();
            PartySizeCombo.Text = "";
            DataSheetCombo.Text = "";
            ObserverCombo.Text = "";
            SpeciesCombo.Text = "";
            LocationCombo.Text = "";
            GroupIDBox.Text = "";
            CommentBox.Text = "";
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            //edit button is clicked
            if (e.ColumnIndex == 50)
            {
              //  int bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Edit was clicked", "OK");
            }
            //deletebutton is clicked
            if (e.ColumnIndex == 51)
            {
               DialogResult result = MessageBox.Show("Are you sure you would like to delete this reccord?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                     //delete the record from the Book table
                   // dataGridView1.Rows.RemoveAt(e.RowIndex); //delete the row from the DataGridView
                }
            }
           
        }

       

     

         
       

        }
    }


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
    public partial class CreateEntry : Form
    {
        public CreateEntry()
        {
            InitializeComponent();
            GorillaHabEncounterPanel.Hide();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Gorilla Habituation")
            {
                GorillaHabEncounterPanel.Show();
                //GorillaHabEncounterPanel.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "panel2")
            {
                //panel2.Show();
                GorillaHabEncounterPanel.Hide();
            }
        }
    }
}

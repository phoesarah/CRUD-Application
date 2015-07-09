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
            GorillaHabNestPanel.Hide();
            GorillaHabScanPanel.Hide();
            GorillaHabObservationPanel.Hide();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Gorilla Habituation")
            {
                GorillaHabEncounterPanel.Show();

                GorillaHabNestPanel.Hide();
                GorillaHabScanPanel.Hide();
                GorillaHabObservationPanel.Hide();
              
            }
            if (comboBox1.SelectedItem.ToString() == "Gor_Habit_Nest")
            {
                
                GorillaHabNestPanel.Show();

                GorillaHabEncounterPanel.Hide();
                GorillaHabScanPanel.Hide();
                GorillaHabObservationPanel.Hide();
                
            }
             if (comboBox1.SelectedItem.ToString() == "Gorilla_Hab_Scan")
             {
                 GorillaHabScanPanel.Show();

                 GorillaHabEncounterPanel.Hide();
                 GorillaHabNestPanel.Hide();
                 GorillaHabObservationPanel.Hide();
                
             }
             else if (comboBox1.SelectedItem.ToString() == "Gorilla_Hab_Observation")
            {
                GorillaHabObservationPanel.Show();

                GorillaHabEncounterPanel.Hide();
                GorillaHabNestPanel.Hide();
                GorillaHabScanPanel.Hide();
              
             
            }
        }

        private void label143_Click(object sender, EventArgs e)
        {

        }

       
    }
}

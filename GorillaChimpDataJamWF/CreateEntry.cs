using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaChimpDataJamWF
{
    public partial class CreateEntry : Form
    {
        Gorillas2Entities1 db = new Gorillas2Entities1();
        HabObservation habobs = new HabObservation();
        HabScan habscan = new HabScan();
        HabNest habnest = new HabNest();
        HabEncounter habenc = new HabEncounter();

        //on change of fields, create UniqueID field and  put that to uniqueid.text value
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

      

        private void SubmiutButton_Click(object sender, EventArgs e)
        {
            //submits to Database but total duration does not work. 
            if (comboBox1.SelectedItem.ToString() == "Gorilla Habituation")
            {


               // if (!string.IsNullOrEmpty(FirstContactPointNum.Text)) ;
              //  habenc.FIRST_CONTACT_POINT = Convert.ToInt16(FirstContactPointNum.Text);
                habenc.DATA_SET = "gorilla habituation";
                habenc.SPECIES = SpeciesComboBox.Text;
                habenc.UNIQUE_CONTACT_ID = UniqueContactIDText.Text;
                habenc.OBSERVER = ObserverTextBox.Text;
                habenc.TRACKER = TrackerTextBox.Text;
                habenc.DATE = dateTimePicker1.Value.Date;
                habenc.MONTH = dateTimePicker1.Value.Month.ToString("MMMM");
                habenc.DAY = Convert.ToInt16(dateTimePicker1.Value.Day);
                habenc.YEAR = Convert.ToInt16(dateTimePicker1.Value.Year);
                habenc.C_COMMUNITY_ = CommunityText.Text;
                habenc.C_DETECTION_1_ = Detection1Text.Text;
                habenc.C_DETECTION_2_ = Detection2Text.Text;
                habenc.LAT = LatitudeText.Text;
                habenc.LONG = LongitudeText.Text;
                habenc.C_FOREST_TYPE_CODE_ = ForestTypeCodeBox.Text;
                habenc.FOREST_TYPE = ForestTypeBox.Text;
                habenc.UNDERSTOREY = UnderstoreyTextBox.Text;
                habenc.CANOPY = CanopyTextBox.Text;
                habenc.START_TIME = StartTimeTextBox.Text;
                habenc.END_TIME = EndTimeTextBox.Text;
                habenc.DURATION = DurationTextBox.Text;
                habenc.HOURS = HoursTextBox.Text;
                habenc.MIN = MinuteTextBox.Text;
                //could not import data as int without going through data and deleting blanks and n/a sometimes they are putting words so did not change to int
               // if (HoursTextBox.Text != null || MinuteTextBox.Text != null)
              //  habenc.TOTAL_DURATION = ((Convert.ToInt32(HoursTextBox.Text)*60) + (Convert.ToInt32(MinuteTextBox.Text)).ToString());
                habenc.C_RESPONSE_1_ = Response1TextBox.Text;
                habenc.RESPONSE_2 = Response2TextBox.Text;
                habenc.END_CONTACT = EndContactTextBox.Text;
                habenc.TYPE_GROUP = TypeGroupTextBox.Text;
                habenc.GROUP_ID = GroupIDTextBox.Text;
                habenc.CONTACT_NMBR = ContactNumberTextBox.Text;
                habenc.DISTANCE_HUMANS_M = DistancefromHumansTextBox.Text;
                habenc.TOTAL = TotalTextBox.Text;
                habenc.C_ORIGINAL_PARTY_SIZE_ = OriginalPartySizeTextBox.Text;
                habenc.NEW_ARRIVALS = NewArrivalTextBox.Text;
                if (!string.IsNullOrEmpty(AmGorObs.Text))
                habenc.AM_GOR_OBS = AmGorObs.Text;
                if (!string.IsNullOrEmpty(AfGorObsTextBox.Text))
                habenc.AF_GOR_OBS = AfGorObsTextBox.Text;
                if (!string.IsNullOrEmpty(SMGorObsTextBox.Text))
                habenc.SM_GOR_OBS = Convert.ToInt16(SMGorObsTextBox.Text);
                if (!string.IsNullOrEmpty(SFGorObsTextBox.Text))
                habenc.SF_GOR_OBS = Convert.ToInt16(SFGorObsTextBox.Text);
                if (!string.IsNullOrEmpty(JVGorObsTextBox.Text))
                habenc.JV_GOR_OBS = Convert.ToInt16(JVGorObsTextBox.Text);
                if (!string.IsNullOrEmpty(InfGorObsTextBox.Text))
                habenc.INF_GOR_OBS = Convert.ToInt16(InfGorObsTextBox.Text);
                if (!string.IsNullOrEmpty(UKGorObsTextBox.Text))
                habenc.UK_GOR_OBS = Convert.ToInt16(UKGorObsTextBox.Text);
                habenc.WEATHER = WeatherTextBox.Text;
                habenc.COMMENTS = CommentsTextBox.Text;
                habenc.INITIAL_LOCATION = InitialLocationTextBox.Text;
                habenc.NEST_TOTAL = NestTotalTextBox.Text;
                habenc.NEST_AGE = NestAgeTextBox.Text;

                db.HabEncounters.Add(habenc);
                db.SaveChanges();
                ClearTextBoxes();
                ClearRichTextBoxes();

            }
            //this submits to DB as is
            if (comboBox1.SelectedItem.ToString() == "Gor_Habit_Nest")
            {
                habnest.DATA_SHEET = "GOR_HABIT_NEST";
                habnest.UNIQUE_CONTACT_ID = UniqueContactIdHabNestText.Text;
                habnest.DATE = DateTimeHabNest.Value.Date;
                habnest.OBSERVER = ObserverHabNestTextBox.Text;
                habnest.YEAR = Convert.ToInt16(DateTimeHabNest.Value.Year);
                habnest.MONTH = DateTimeHabNest.Value.Month.ToString("MMMM");
                habnest.DAY = Convert.ToInt16(DateTimeHabNest.Value.Day);
               if (!string.IsNullOrEmpty(NestNumberHabNestTextBox.Text))
                   habnest.NEST_NUMBER = Convert.ToInt16(NestNumberHabNestTextBox.Text);
                habnest.LOCATION = LocationHabNestTexTBox.Text;
                habnest.DUNG_PRESENT = DungPresentHabNestTextBox.Text;
                habnest.SAMPLE_ID = SampleIDHabNestTexTbox.Text;
                habnest.NEST_TYPE = NestTypeHabNest.Text;
                habnest.FOREST_TYPE_CODE = ForestTypeCodeHabNestText.Text;
                habnest.FOREST_TYPE = ForestTypeHabNestText.Text;
                habnest.UNDERSTOREY = UnderstoryHabNestText.Text;
                habnest.CANOPY = CanopyHabNestText.Text;
                habnest.NEST_AGE = NestAgeHabNestText.Text;
                if (!string.IsNullOrEmpty(SitesizeHabNest.Text))
                    habnest.SITE_SIZE = Convert.ToInt16(SitesizeHabNest.Text);
                habnest.COMMENT = CommentsHabNestText.Text;

                db.HabNests.Add(habnest);
                db.SaveChanges();
                ClearTextBoxes();
                ClearRichTextBoxes();

            }


            if (comboBox1.SelectedItem.ToString() == "Gorilla_Hab_Scan")
            {
                habscan.ACTIVITY = ActivityHabScan.Text;
                habscan.COMMENT = CommentsHabScan.Text;
                habscan.C_APE_SPECIES_ = SpeciesHabScan.Text;
                habscan.C_DATA_SHEET_ = "GORILLA_ SCAN_DATA";
                habscan.C_ENCOUNTER_ = UniqueContactIDHabScan.Text;
                habscan.C_OBSERVER_ = ObserverHabScan.Text;
                habscan.FDNOTE = FDNoteHabScan.Text;
                habscan.FDTOTAL = FD_TOT.Text;
                habscan.FD_SA = FD_SA.Text;
                habscan.INDIVIDUAL = IndividualHabScan.Text;
                habscan.IN_JUVF = IN_JUVF.Text;
                habscan.DATE = dateTimeHabScan.Value.Date;
                habscan.DAY = Convert.ToInt16(dateTimeHabScan.Value.Day);
                habscan.MONTH = dateTimeHabScan.Value.Month.ToString("MMMM");
                habscan.YEAR = Convert.ToInt16(dateTimeHabScan.Value.Year);
                if (!string.IsNullOrEmpty(HourTextBoxHabScan.Text))
                habscan.HOUR = Convert.ToInt16(HourTextBoxHabScan.Text);
                if (!string.IsNullOrEmpty(MinutesHabScan.Text))
                habscan.MINUTE = Convert.ToInt16(MinutesHabScan.Text);
                habscan.LOCATION = LocationHabScan.Text;
                if (!string.IsNullOrEmpty(ScanPartySizeHabScan.Text))
                habscan.SCAN_PARTY_SIZE = Convert.ToInt16(ScanPartySizeHabScan.Text);
                if (!string.IsNullOrEmpty(IN_AM.Text))
                habscan.IN_AM = Convert.ToInt16(IN_AM.Text);
                if (!string.IsNullOrEmpty(IN_AF.Text))
                habscan.IN_AF = Convert.ToInt16(IN_AF.Text);
                if (!string.IsNullOrEmpty(IN_AD.Text))
                habscan.IN_AD = Convert.ToInt16(IN_AD.Text);
                if (!string.IsNullOrEmpty(IN_SAM.Text))
                habscan.IN_SAM = Convert.ToInt16(IN_SAM.Text);
                if (!string.IsNullOrEmpty(IN_SAF.Text))
                habscan.IN_SAF = Convert.ToInt16(IN_SAF.Text);
                if (!string.IsNullOrEmpty(IN_SA.Text))
                habscan.IN_SA = Convert.ToInt16(IN_SA.Text);
                if (!string.IsNullOrEmpty(IN_JUVM.Text))
                habscan.IN_JUVM = Convert.ToInt16(IN_JUVM.Text);
                habscan.IN_JUVF = IN_JUVF.Text;
                if (!string.IsNullOrEmpty(IN_JUV.Text))
                habscan.IN_JUV = Convert.ToInt16(IN_JUV.Text);
                if (!string.IsNullOrEmpty(IN_INF.Text))
                habscan.IN_INF = Convert.ToInt16(IN_INF.Text);
                if (!string.IsNullOrEmpty(IN_UK.Text))
                habscan.IN_UK = Convert.ToInt16(IN_UK.Text);
                habscan.NEST = NestHabScan.Text;
                habscan.IN_TOT = IN_TOT.Text;
                if (!string.IsNullOrEmpty(FD_AM.Text))
                habscan.FD_AM = Convert.ToInt16(FD_AM.Text);
                if (!string.IsNullOrEmpty(FD_AF.Text))
                habscan.FD_AF = Convert.ToInt16(FD_AF.Text);
                if (!string.IsNullOrEmpty(FD_SAM.Text))
                habscan.FD_SAM = Convert.ToInt16(FD_SAM.Text);
                if (!string.IsNullOrEmpty(FD_SAF.Text))
                habscan.FD_SAF = Convert.ToInt16(FD_SAF.Text);
                if (!string.IsNullOrEmpty(FD_JUVM.Text))
                habscan.FD_JUVM = Convert.ToInt16(FD_JUVM.Text);
                if (!string.IsNullOrEmpty(FD_JUVF.Text))
                habscan.FD_JUVF = Convert.ToInt16(FD_JUVF.Text);
                if (!string.IsNullOrEmpty(FD_JUV.Text))
                habscan.FD_JUV = Convert.ToInt16(FD_JUV.Text);
                if (!string.IsNullOrEmpty(FD_INF.Text))
                habscan.FD_INF = Convert.ToInt16(FD_INF.Text);
                if (!string.IsNullOrEmpty(FD_UK.Text))
                habscan.FD_UK = Convert.ToInt16(FD_UK.Text);
                habscan.LOCAL_NAME = LocalNameHabScan.Text;
                habscan.SCIENTIFIC_NAME = ScientificNameHabScan.Text;
                habscan.PART = PartHabScan.Text;
                habscan.SIMPLE_PART = SimplePartHabScan.Text;
                if (!string.IsNullOrEmpty(TR_AM.Text))
                habscan.TR_AM = Convert.ToInt16(TR_AM.Text);
                if (!string.IsNullOrEmpty(TR_AF.Text))
                habscan.TR_AF = Convert.ToInt16(TR_AF.Text);
                if (!string.IsNullOrEmpty(TR_SAM.Text))
                habscan.TR_SAM = Convert.ToInt16(TR_SAM.Text);
                if (!string.IsNullOrEmpty(TR_SAF.Text))
                habscan.TR_SAF = Convert.ToInt16(TR_SAF.Text);
                if (!string.IsNullOrEmpty(TR_SA.Text))
                habscan.TR_SA = Convert.ToInt16(TR_SA.Text);
                if (!string.IsNullOrEmpty(TR_JUVM.Text))
                habscan.TR_JUVM = Convert.ToInt16(TR_JUVM.Text);
                if (!string.IsNullOrEmpty(TR_JUVF.Text))
                habscan.TR_JUVF = Convert.ToInt16(TR_JUVF.Text);
                if (!string.IsNullOrEmpty(TR_JUV.Text))
                habscan.TR_JUV = Convert.ToInt16(TR_JUV.Text);
                if (!string.IsNullOrEmpty(TR_INF.Text))
                habscan.TR_INF = Convert.ToInt16(TR_INF.Text);
                if (!string.IsNullOrEmpty(TR_UK.Text))
                habscan.TR_UK = Convert.ToInt16(TR_UK.Text);
                habscan.TR_TOT = TR_TOT.Text;
                if (!string.IsNullOrEmpty(OT_AM.Text))
                habscan.OT_AM = Convert.ToInt16(OT_AM.Text);
                if (!string.IsNullOrEmpty(OT_AF.Text))
                habscan.OT_AF = Convert.ToInt16(OT_AF.Text);
                if (!string.IsNullOrEmpty(OT_SAM.Text))
                habscan.OT_SAM = Convert.ToInt16(OT_SAM.Text);
                if (!string.IsNullOrEmpty(TR_SAF.Text))
                habscan.OT_SAF = OT_SAF.Text;
                habscan.OT_SA = OT_SA.Text;
                if (!string.IsNullOrEmpty(OT_JUVM.Text))
                habscan.OT_JUVM = Convert.ToInt16(OT_JUVM.Text);
                habscan.OT_JUVF = OT_JUVF.Text;
                habscan.OT_JUV = OT_JUV.Text;
                if (!string.IsNullOrEmpty(OT_INF.Text))
                habscan.OT_INF = Convert.ToInt16(OT_INF.Text);
                habscan.OT_UK = OT_UK.Text;
                habscan.OT_TOT = OT_TOT.Text;
                habscan.OTHER_BEHAVIOR = OtherBehaviorHabScan.Text;
                habscan.OBJECT = ObjectHabScan.Text;
                habscan.ACTIVITY = ActivityHabScan.Text;
                habscan.SO_AM = SO_AM.Text;
                if (!string.IsNullOrEmpty(SO_AF.Text))
                habscan.SO_AF = Convert.ToInt16(SO_AF.Text);
                if (!string.IsNullOrEmpty(SO_SAM.Text))
                habscan.SO_SAM = Convert.ToInt16(SO_SAM.Text);
                habscan.SO_SAF = SO_SAF.Text;
                habscan.SO_SA = SO_SA.Text;
                if (!string.IsNullOrEmpty(SO_JUVM.Text))
                habscan.SO_JUVM = Convert.ToInt16(SO_JUVM.Text);
                habscan.SO_JUVF = SO_JUVM.Text;
                habscan.SO_JUV = SO_JUV.Text;
                if (!string.IsNullOrEmpty(SO_INF.Text))
                habscan.SO_INF = Convert.ToInt16(SO_INF.Text);
                habscan.SO_UK = SO_UK.Text;
                habscan.SO_TOT = SO_TOT.Text;
                habscan.SOCIAL = SocialHabScan.Text;
                habscan.RECIPROCITY = ReciprocityHabScan.Text;
                habscan.OOV_AM = OOV_AM.Text;
                if (!string.IsNullOrEmpty(OOV_AF.Text))
                habscan.OOV_AF = Convert.ToInt16(OOV_AF.Text);
                if (!string.IsNullOrEmpty(OOV_SAM.Text))
                habscan.OOV_SAM = Convert.ToInt16(OOV_SAM.Text);
                if (!string.IsNullOrEmpty(OOV_SAF.Text))
                habscan.OOV_SAF = Convert.ToInt16(OOV_SAF.Text);
                habscan.OOV_SA = OOV_SA.Text;
                if (!string.IsNullOrEmpty(OOV_JUVM.Text))
                habscan.OOV_JUVM = Convert.ToInt16(OOV_JUVM.Text);
                if (!string.IsNullOrEmpty(OOV_JUVF.Text))
                habscan.OOV_JUVF = Convert.ToInt16(OOV_JUVF.Text);
                if (!string.IsNullOrEmpty(OOV_JUV.Text))
                habscan.OOV_JUV = Convert.ToInt16(OOV_JUV.Text);
                if (!string.IsNullOrEmpty(OOV_INF.Text))
                habscan.OOV_INF = Convert.ToInt16(OOV_INF.Text);
                if (!string.IsNullOrEmpty(OOV_UK.Text))
                habscan.OOV_UK = Convert.ToInt16(OOV_UK.Text);
                habscan.OOV_TOT = OOV_TOT.Text;
       

                db.HabScans.Add(habscan);
                db.SaveChanges();
                ClearTextBoxes();
                ClearRichTextBoxes();

            }
                //works
            else if (comboBox1.SelectedItem.ToString() == "Gorilla_Hab_Observation")
            {

                habobs.BEHAVIOR = BehaviorHabObs.Text;
                habobs.COMMENT = CommentHabObs.Text;
                habobs.DATA_SHEET = "GOR_HABIT_OBSERVATION";
                habobs.DATE = GorillaHabOBsDatePicker.Value.Date;
                habobs.DAY = Convert.ToInt16(GorillaHabOBsDatePicker.Value.Day);
                habobs.HOUR = HourHabObs.Text;
                habobs.INDIVIDUAL = IndividualHabObs.Text;
                habobs.MONTH = GorillaHabOBsDatePicker.Value.Month.ToString("MMMM");
                habobs.UNIQUE_ENCOUNTER_ID = UniqueContactIDHabObs.Text;
                habobs.YEAR = Convert.ToInt16(GorillaHabOBsDatePicker.Value.Year);

                db.HabObservations.Add(habobs);
                db.SaveChanges();
                ClearTextBoxes();
                ClearRichTextBoxes();


            }
            
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);


            };

            func(Controls);
        }

        private void ClearRichTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);


            };

            func(Controls);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}

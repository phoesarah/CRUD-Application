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


                if (FirstContactPointNum == null)
                habenc.FIRST_CONTACT_POINT = Convert.ToInt16(FirstContactPointNum.Text);
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
                if (HoursTextBox == null || MinuteTextBox == null)
                habenc.TOTAL_DURATION = ((Convert.ToInt32(HoursTextBox.Text)*60) + (Convert.ToInt32(MinuteTextBox.Text)).ToString());
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
                if (AmGorObs == null)
                habenc.AM_GOR_OBS = AmGorObs.Text;
                if (AfGorObsTextBox == null)
                habenc.AF_GOR_OBS = AfGorObsTextBox.Text;
                if (SMGorObsTextBox == null)
                habenc.SM_GOR_OBS = Convert.ToInt16(SMGorObsTextBox.Text);
                if (SFGorObsTextBox == null)
                habenc.SF_GOR_OBS = Convert.ToInt16(SFGorObsTextBox.Text);
                if (JVGorObsTextBox == null)
                habenc.JV_GOR_OBS = Convert.ToInt16(JVGorObsTextBox.Text);
                if (InfGorObsTextBox == null)
                habenc.INF_GOR_OBS = Convert.ToInt16(InfGorObsTextBox.Text);
                if (UKGorObsTextBox == null)
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
               if (NestNumberHabNestTextBox == null)
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
                if (SitesizeHabNest == null)
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
                if (HourTextBoxHabScan == null)
                habscan.HOUR = Convert.ToInt16(HourTextBoxHabScan.Text);
                if (MinutesHabScan == null)
                habscan.MINUTE = Convert.ToInt16(MinutesHabScan.Text);
                habscan.LOCATION = LocationHabScan.Text;
                if (ScanPartySizeHabScan == null)
                habscan.SCAN_PARTY_SIZE = Convert.ToInt16(ScanPartySizeHabScan.Text);
                if (IN_AM == null)
                habscan.IN_AM = Convert.ToInt16(IN_AM.Text);
                if (IN_AF == null)
                habscan.IN_AF = Convert.ToInt16(IN_AF.Text);
                if (IN_AD == null)
                habscan.IN_AD = Convert.ToInt16(IN_AD.Text);
                if (IN_SAM == null)
                habscan.IN_SAM = Convert.ToInt16(IN_SAM.Text);
                if (IN_SAF == null)
                habscan.IN_SAF = Convert.ToInt16(IN_SAF.Text);
                if (IN_SA == null)
                habscan.IN_SA = Convert.ToInt16(IN_SA.Text);
                if (IN_JUVM == null)
                habscan.IN_JUVM = Convert.ToInt16(IN_JUVM);
                habscan.IN_JUVF = IN_JUVF.Text;
                if (IN_JUV == null)
                habscan.IN_JUV = Convert.ToInt16(IN_JUV.Text);
                if (IN_INF == null)
                habscan.IN_INF = Convert.ToInt16(IN_INF.Text);
                if (IN_UK == null)
                habscan.IN_UK = Convert.ToInt16(IN_UK.Text);
                habscan.NEST = NestHabScan.Text;
                habscan.IN_TOT = IN_TOT.Text;
                if (FD_AM == null)
                habscan.FD_AM = Convert.ToInt16(FD_AM.Text);
                if (FD_AF == null)
                habscan.FD_AF = Convert.ToInt16(FD_AF.Text);
                if (FD_SAM == null)
                habscan.FD_SAM = Convert.ToInt16(FD_SAM.Text);
                if (FD_SAF == null)
                habscan.FD_SAF = Convert.ToInt16(FD_SAF.Text);
                if (FD_JUVM == null)
                habscan.FD_JUVM = Convert.ToInt16(FD_JUVM.Text);
                if (FD_JUVF == null)
                habscan.FD_JUVF = Convert.ToInt16(FD_JUVF.Text);
                if (FD_JUV == null)
                habscan.FD_JUV = Convert.ToInt16(FD_JUV.Text);
                if (FD_INF == null)
                habscan.FD_INF = Convert.ToInt16(FD_INF.Text);
                if (FD_UK == null)
                habscan.FD_UK = Convert.ToInt16(FD_UK.Text);
                habscan.LOCAL_NAME = LocalNameHabScan.Text;
                habscan.SCIENTIFIC_NAME = ScientificNameHabScan.Text;
                habscan.PART = PartHabScan.Text;
                habscan.SIMPLE_PART = SimplePartHabScan.Text;
                if (TR_AM == null)
                habscan.TR_AM = Convert.ToInt16(TR_AM.Text);
                if (TR_AF == null)
                habscan.TR_AF = Convert.ToInt16(TR_AF.Text);
                if (TR_SAM == null)
                habscan.TR_SAM = Convert.ToInt16(TR_SAM.Text);
                if (TR_SAF == null)
                habscan.TR_SAF = Convert.ToInt16(TR_SAF.Text);
                if (TR_SA == null)
                habscan.TR_SA = Convert.ToInt16(TR_SA.Text);
                if (TR_JUVM == null)
                habscan.TR_JUVM = Convert.ToInt16(TR_JUVM.Text);
                if (TR_JUVF== null)
                habscan.TR_JUVF = Convert.ToInt16(TR_JUVF.Text);
                if (TR_JUV == null)
                habscan.TR_JUV = Convert.ToInt16(TR_JUV.Text);
                if (TR_INF == null)
                habscan.TR_INF = Convert.ToInt16(TR_INF.Text);
                if (TR_UK == null)
                habscan.TR_UK = Convert.ToInt16(TR_UK.Text);
                habscan.TR_TOT = TR_TOT.Text;
                if (OT_AM == null)
                habscan.OT_AM = Convert.ToInt16(OT_AM.Text);
                if (OT_AF == null)
                habscan.OT_AF = Convert.ToInt16(OT_AF.Text);
                if (OT_SAM == null)
                habscan.OT_SAM = Convert.ToInt16(OT_SAM.Text);
                if (TR_SAF == null)
                habscan.OT_SAF = OT_SAF.Text;
                habscan.OT_SA = OT_SA.Text;
                if (OT_JUVM == null)
                habscan.OT_JUVM = Convert.ToInt16(OT_JUVM.Text);
                habscan.OT_JUVF = OT_JUVF.Text;
                habscan.OT_JUV = OT_JUV.Text;
                if (OT_INF== null)
                habscan.OT_INF = Convert.ToInt16(OT_INF.Text);
                habscan.OT_UK = OT_UK.Text;
                habscan.OT_TOT = OT_TOT.Text;
                habscan.OTHER_BEHAVIOR = OtherBehaviorHabScan.Text;
                habscan.OBJECT = ObjectHabScan.Text;
                habscan.ACTIVITY = ActivityHabScan.Text;
                habscan.SO_AM = SO_AM.Text;
                if (SO_AF == null)
                habscan.SO_AF = Convert.ToInt16(SO_AF.Text);
                if (SO_SAM == null)
                habscan.SO_SAM = Convert.ToInt16(SO_SAM.Text);
                habscan.SO_SAF = SO_SAF.Text;
                habscan.SO_SA = SO_SA.Text;
                if (SO_JUVM == null)
                habscan.SO_JUVM = Convert.ToInt16(SO_JUVM.Text);
                habscan.SO_JUVF = SO_JUVM.Text;
                habscan.SO_JUV = SO_JUV.Text;
                if (SO_INF == null)
                habscan.SO_INF = Convert.ToInt16(SO_INF.Text);
                habscan.SO_UK = SO_UK.Text;
                habscan.SO_TOT = SO_TOT.Text;
                habscan.SOCIAL = SocialHabScan.Text;
                habscan.RECIPROCITY = ReciprocityHabScan.Text;
                habscan.OOV_AM = OOV_AM.Text;
                if (OOV_AF == null)
                habscan.OOV_AF = Convert.ToInt16(OOV_AF.Text);
                if (OOV_SAM == null)
                habscan.OOV_SAM = Convert.ToInt16(OOV_SAM.Text);
                if (OOV_SAF == null)
                habscan.OOV_SAF = Convert.ToInt16(OOV_SAF.Text);
                habscan.OOV_SA = OOV_SA.Text;
                if (OOV_JUVM == null)
                habscan.OOV_JUVM = Convert.ToInt16(OOV_JUVM.Text);
                if (OOV_JUVF == null)
                habscan.OOV_JUVF = Convert.ToInt16(OOV_JUVF.Text);
                if (OOV_JUV == null)
                habscan.OOV_JUV = Convert.ToInt16(OOV_JUV.Text);
                if (OOV_INF == null)
                habscan.OOV_INF = Convert.ToInt16(OOV_INF.Text);
                if (OOV_UK == null)
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
      
    }
}

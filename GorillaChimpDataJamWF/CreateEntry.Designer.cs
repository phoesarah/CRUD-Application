namespace GorillaChimpDataJamWF
{
    partial class CreateEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GorillaHabEncounterPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstContactPointNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmiutButton = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SpeciesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UniqueContactIDText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ObserverTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TrackerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Detection1Text = new System.Windows.Forms.TextBox();
            this.Detection2Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LatitudeText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LongitudeText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GorillaHabEncounterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstContactPointNum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gorilla Habituation",
            "Gorilla_Hab_Nest",
            "Gorilla_Hab_Scan",
            "Gorilla_Hab_Observation"});
            this.comboBox1.Location = new System.Drawing.Point(24, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataSet";
            // 
            // GorillaHabEncounterPanel
            // 
            this.GorillaHabEncounterPanel.Controls.Add(this.label14);
            this.GorillaHabEncounterPanel.Controls.Add(this.label13);
            this.GorillaHabEncounterPanel.Controls.Add(this.LongitudeText);
            this.GorillaHabEncounterPanel.Controls.Add(this.label12);
            this.GorillaHabEncounterPanel.Controls.Add(this.LatitudeText);
            this.GorillaHabEncounterPanel.Controls.Add(this.label11);
            this.GorillaHabEncounterPanel.Controls.Add(this.Detection2Text);
            this.GorillaHabEncounterPanel.Controls.Add(this.Detection1Text);
            this.GorillaHabEncounterPanel.Controls.Add(this.label10);
            this.GorillaHabEncounterPanel.Controls.Add(this.label9);
            this.GorillaHabEncounterPanel.Controls.Add(this.textBox1);
            this.GorillaHabEncounterPanel.Controls.Add(this.label8);
            this.GorillaHabEncounterPanel.Controls.Add(this.dateTimePicker1);
            this.GorillaHabEncounterPanel.Controls.Add(this.label7);
            this.GorillaHabEncounterPanel.Controls.Add(this.TrackerTextBox);
            this.GorillaHabEncounterPanel.Controls.Add(this.label6);
            this.GorillaHabEncounterPanel.Controls.Add(this.ObserverTextBox);
            this.GorillaHabEncounterPanel.Controls.Add(this.label5);
            this.GorillaHabEncounterPanel.Controls.Add(this.UniqueContactIDText);
            this.GorillaHabEncounterPanel.Controls.Add(this.label4);
            this.GorillaHabEncounterPanel.Controls.Add(this.SpeciesComboBox);
            this.GorillaHabEncounterPanel.Controls.Add(this.label3);
            this.GorillaHabEncounterPanel.Controls.Add(this.FirstContactPointNum);
            this.GorillaHabEncounterPanel.Controls.Add(this.label2);
            this.GorillaHabEncounterPanel.Location = new System.Drawing.Point(27, 90);
            this.GorillaHabEncounterPanel.Name = "GorillaHabEncounterPanel";
            this.GorillaHabEncounterPanel.Size = new System.Drawing.Size(1117, 453);
            this.GorillaHabEncounterPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Contact Point:";
            // 
            // FirstContactPointNum
            // 
            this.FirstContactPointNum.Location = new System.Drawing.Point(13, 65);
            this.FirstContactPointNum.Name = "FirstContactPointNum";
            this.FirstContactPointNum.Size = new System.Drawing.Size(44, 20);
            this.FirstContactPointNum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Species:";
            // 
            // SubmiutButton
            // 
            this.SubmiutButton.Location = new System.Drawing.Point(1025, 599);
            this.SubmiutButton.Name = "SubmiutButton";
            this.SubmiutButton.Size = new System.Drawing.Size(75, 23);
            this.SubmiutButton.TabIndex = 3;
            this.SubmiutButton.Text = "Submit";
            this.SubmiutButton.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(1106, 599);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close Form";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // SpeciesComboBox
            // 
            this.SpeciesComboBox.FormattingEnabled = true;
            this.SpeciesComboBox.Items.AddRange(new object[] {
            "Gorilla"});
            this.SpeciesComboBox.Location = new System.Drawing.Point(138, 65);
            this.SpeciesComboBox.Name = "SpeciesComboBox";
            this.SpeciesComboBox.Size = new System.Drawing.Size(108, 21);
            this.SpeciesComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(940, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unique Contact ID:";
            // 
            // UniqueContactIDText
            // 
            this.UniqueContactIDText.Location = new System.Drawing.Point(943, 64);
            this.UniqueContactIDText.Name = "UniqueContactIDText";
            this.UniqueContactIDText.Size = new System.Drawing.Size(140, 20);
            this.UniqueContactIDText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Observer:";
            // 
            // ObserverTextBox
            // 
            this.ObserverTextBox.Location = new System.Drawing.Point(265, 66);
            this.ObserverTextBox.Name = "ObserverTextBox";
            this.ObserverTextBox.Size = new System.Drawing.Size(100, 20);
            this.ObserverTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tracker:";
            // 
            // TrackerTextBox
            // 
            this.TrackerTextBox.Location = new System.Drawing.Point(388, 65);
            this.TrackerTextBox.Name = "TrackerTextBox";
            this.TrackerTextBox.Size = new System.Drawing.Size(100, 20);
            this.TrackerTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Community:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Detection 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(739, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Detection 2:";
            // 
            // Detection1Text
            // 
            this.Detection1Text.Location = new System.Drawing.Point(619, 64);
            this.Detection1Text.Name = "Detection1Text";
            this.Detection1Text.Size = new System.Drawing.Size(100, 20);
            this.Detection1Text.TabIndex = 16;
            // 
            // Detection2Text
            // 
            this.Detection2Text.Location = new System.Drawing.Point(742, 64);
            this.Detection2Text.Name = "Detection2Text";
            this.Detection2Text.Size = new System.Drawing.Size(100, 20);
            this.Detection2Text.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Latitude:";
            // 
            // LatitudeText
            // 
            this.LatitudeText.Location = new System.Drawing.Point(15, 129);
            this.LatitudeText.Name = "LatitudeText";
            this.LatitudeText.Size = new System.Drawing.Size(100, 20);
            this.LatitudeText.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Longitude";
            // 
            // LongitudeText
            // 
            this.LongitudeText.Location = new System.Drawing.Point(141, 129);
            this.LongitudeText.Name = "LongitudeText";
            this.LongitudeText.Size = new System.Drawing.Size(100, 20);
            this.LongitudeText.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Forest Type Code:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Forest Type:";
            // 
            // CreateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 656);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SubmiutButton);
            this.Controls.Add(this.GorillaHabEncounterPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "CreateEntry";
            this.Text = "CreateEntry";
            this.GorillaHabEncounterPanel.ResumeLayout(false);
            this.GorillaHabEncounterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstContactPointNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GorillaHabEncounterPanel;
        private System.Windows.Forms.NumericUpDown FirstContactPointNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SpeciesComboBox;
        private System.Windows.Forms.Button SubmiutButton;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox UniqueContactIDText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ObserverTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TrackerTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Detection2Text;
        private System.Windows.Forms.TextBox Detection1Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LatitudeText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LongitudeText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}
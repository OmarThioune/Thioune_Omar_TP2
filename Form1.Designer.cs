namespace TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonReservation = new Button();
            buttonQuitter = new Button();
            dateTimePickerArrivee = new DateTimePicker();
            dateTimePickerDepart = new DateTimePicker();
            labelArrivee = new Label();
            labelDepart = new Label();
            comboBoxHebergement = new ComboBox();
            pictureBoxPaysage = new PictureBox();
            pictureBoxCamping = new PictureBox();
            labelCamping = new Label();
            label1 = new Label();
            errorProviderDate = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPaysage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            SuspendLayout();
            // 
            // buttonReservation
            // 
            buttonReservation.Location = new Point(28, 350);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(191, 62);
            buttonReservation.TabIndex = 0;
            buttonReservation.Text = "Réservation";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(243, 350);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(201, 62);
            buttonQuitter.TabIndex = 1;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // dateTimePickerArrivee
            // 
            dateTimePickerArrivee.Location = new Point(28, 311);
            dateTimePickerArrivee.Name = "dateTimePickerArrivee";
            dateTimePickerArrivee.Size = new Size(191, 23);
            dateTimePickerArrivee.TabIndex = 2;
            dateTimePickerArrivee.ValueChanged += dateTimePickerArrivee_ValueChanged;
            // 
            // dateTimePickerDepart
            // 
            dateTimePickerDepart.Location = new Point(243, 311);
            dateTimePickerDepart.Name = "dateTimePickerDepart";
            dateTimePickerDepart.Size = new Size(201, 23);
            dateTimePickerDepart.TabIndex = 3;
            // 
            // labelArrivee
            // 
            labelArrivee.AutoSize = true;
            labelArrivee.Location = new Point(28, 293);
            labelArrivee.Name = "labelArrivee";
            labelArrivee.Size = new Size(79, 15);
            labelArrivee.TabIndex = 4;
            labelArrivee.Text = "Date d'arrivée";
            labelArrivee.Click += labelArrivee_Click;
            // 
            // labelDepart
            // 
            labelDepart.AutoSize = true;
            labelDepart.Location = new Point(360, 293);
            labelDepart.Name = "labelDepart";
            labelDepart.Size = new Size(84, 15);
            labelDepart.TabIndex = 5;
            labelDepart.Text = "Date de départ";
            // 
            // comboBoxHebergement
            // 
            comboBoxHebergement.FormattingEnabled = true;
            comboBoxHebergement.Items.AddRange(new object[] { "Secteur du Lac", "Secteur du Fleuve" });
            comboBoxHebergement.Location = new Point(28, 251);
            comboBoxHebergement.Name = "comboBoxHebergement";
            comboBoxHebergement.Size = new Size(416, 23);
            comboBoxHebergement.TabIndex = 6;
            comboBoxHebergement.Text = "Choix des hébergements";
            comboBoxHebergement.SelectedIndexChanged += comboBoxHebergement_SelectedIndexChanged;
            // 
            // pictureBoxPaysage
            // 
            pictureBoxPaysage.ErrorImage = Properties.Resources.Paysage;
            pictureBoxPaysage.Image = Properties.Resources.secteurLac;
            pictureBoxPaysage.InitialImage = Properties.Resources.Paysage;
            pictureBoxPaysage.Location = new Point(122, 105);
            pictureBoxPaysage.Name = "pictureBoxPaysage";
            pictureBoxPaysage.Size = new Size(212, 140);
            pictureBoxPaysage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPaysage.TabIndex = 7;
            pictureBoxPaysage.TabStop = false;
            pictureBoxPaysage.Click += pictureBox1_Click;
            // 
            // pictureBoxCamping
            // 
            pictureBoxCamping.Image = Properties.Resources.camping_icon;
            pictureBoxCamping.Location = new Point(28, 12);
            pictureBoxCamping.Name = "pictureBoxCamping";
            pictureBoxCamping.Size = new Size(94, 83);
            pictureBoxCamping.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCamping.TabIndex = 8;
            pictureBoxCamping.TabStop = false;
            // 
            // labelCamping
            // 
            labelCamping.AutoSize = true;
            labelCamping.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelCamping.Location = new Point(140, 12);
            labelCamping.Name = "labelCamping";
            labelCamping.Size = new Size(207, 45);
            labelCamping.TabIndex = 9;
            labelCamping.Text = "Camping QC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 70);
            label1.Name = "label1";
            label1.Size = new Size(338, 25);
            label1.TabIndex = 10;
            label1.Text = "Système de réservation - Hébergement";
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 450);
            Controls.Add(label1);
            Controls.Add(labelCamping);
            Controls.Add(pictureBoxCamping);
            Controls.Add(pictureBoxPaysage);
            Controls.Add(comboBoxHebergement);
            Controls.Add(labelDepart);
            Controls.Add(labelArrivee);
            Controls.Add(dateTimePickerDepart);
            Controls.Add(dateTimePickerArrivee);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonReservation);
            Name = "Form1";
            Text = "TP2 - Omar Thioune";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPaysage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamping).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReservation;
        private Button buttonQuitter;
        private DateTimePicker dateTimePickerArrivee;
        private DateTimePicker dateTimePickerDepart;
        private Label labelArrivee;
        private Label labelDepart;
        private ComboBox comboBoxHebergement;
        private PictureBox pictureBoxPaysage;
        private PictureBox pictureBoxCamping;
        private Label labelCamping;
        private Label label1;
        private ErrorProvider errorProviderDate;
    }
}
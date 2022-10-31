
namespace Scheduling_App
{
    partial class AddAppointmentForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblConsultant = new System.Windows.Forms.Label();
            this.txtConsultant = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtAptTitle = new System.Windows.Forms.TextBox();
            this.lblApptTitle = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.radioThirty = new System.Windows.Forms.RadioButton();
            this.radioSixty = new System.Windows.Forms.RadioButton();
            this.radioNinety = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.lblAvailableTimes = new System.Windows.Forms.Label();
            this.btnFindTimes = new System.Windows.Forms.Button();
            this.dgvAvailableTimes = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Appointment";
            // 
            // lblConsultant
            // 
            this.lblConsultant.AutoSize = true;
            this.lblConsultant.Location = new System.Drawing.Point(14, 56);
            this.lblConsultant.Name = "lblConsultant";
            this.lblConsultant.Size = new System.Drawing.Size(88, 13);
            this.lblConsultant.TabIndex = 1;
            this.lblConsultant.Text = "Consultant Name";
            // 
            // txtConsultant
            // 
            this.txtConsultant.Location = new System.Drawing.Point(17, 72);
            this.txtConsultant.Name = "txtConsultant";
            this.txtConsultant.Size = new System.Drawing.Size(241, 20);
            this.txtConsultant.TabIndex = 2;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(17, 120);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(241, 20);
            this.txtCustomer.TabIndex = 4;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(14, 104);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer Name";
            // 
            // txtAptTitle
            // 
            this.txtAptTitle.Location = new System.Drawing.Point(17, 171);
            this.txtAptTitle.Name = "txtAptTitle";
            this.txtAptTitle.Size = new System.Drawing.Size(241, 20);
            this.txtAptTitle.TabIndex = 6;
            // 
            // lblApptTitle
            // 
            this.lblApptTitle.AutoSize = true;
            this.lblApptTitle.Location = new System.Drawing.Point(14, 155);
            this.lblApptTitle.Name = "lblApptTitle";
            this.lblApptTitle.Size = new System.Drawing.Size(27, 13);
            this.lblApptTitle.TabIndex = 5;
            this.lblApptTitle.Text = "Title";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Location = new System.Drawing.Point(17, 222);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(241, 104);
            this.txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 206);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(17, 355);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(241, 20);
            this.txtType.TabIndex = 10;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(14, 339);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(17, 403);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(241, 20);
            this.txtContact.TabIndex = 12;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(14, 387);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Contact";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(17, 457);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(241, 20);
            this.txtLocation.TabIndex = 14;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(14, 441);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Location";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(17, 508);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(241, 20);
            this.txtUrl.TabIndex = 16;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(14, 492);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "URL";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(341, 56);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duration";
            // 
            // radioThirty
            // 
            this.radioThirty.AutoSize = true;
            this.radioThirty.Checked = true;
            this.radioThirty.Location = new System.Drawing.Point(344, 72);
            this.radioThirty.Name = "radioThirty";
            this.radioThirty.Size = new System.Drawing.Size(72, 17);
            this.radioThirty.TabIndex = 19;
            this.radioThirty.TabStop = true;
            this.radioThirty.Text = "30 Minute";
            this.radioThirty.UseVisualStyleBackColor = true;
            // 
            // radioSixty
            // 
            this.radioSixty.AutoSize = true;
            this.radioSixty.Location = new System.Drawing.Point(422, 72);
            this.radioSixty.Name = "radioSixty";
            this.radioSixty.Size = new System.Drawing.Size(72, 17);
            this.radioSixty.TabIndex = 20;
            this.radioSixty.Text = "60 Minute";
            this.radioSixty.UseVisualStyleBackColor = true;
            // 
            // radioNinety
            // 
            this.radioNinety.AutoSize = true;
            this.radioNinety.Location = new System.Drawing.Point(500, 72);
            this.radioNinety.Name = "radioNinety";
            this.radioNinety.Size = new System.Drawing.Size(72, 17);
            this.radioNinety.TabIndex = 21;
            this.radioNinety.Text = "90 Minute";
            this.radioNinety.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Start";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(357, 120);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 24;
            // 
            // lblAvailableTimes
            // 
            this.lblAvailableTimes.AutoSize = true;
            this.lblAvailableTimes.Location = new System.Drawing.Point(341, 339);
            this.lblAvailableTimes.Name = "lblAvailableTimes";
            this.lblAvailableTimes.Size = new System.Drawing.Size(81, 13);
            this.lblAvailableTimes.TabIndex = 26;
            this.lblAvailableTimes.Text = "Available Times";
            // 
            // btnFindTimes
            // 
            this.btnFindTimes.Location = new System.Drawing.Point(509, 285);
            this.btnFindTimes.Name = "btnFindTimes";
            this.btnFindTimes.Size = new System.Drawing.Size(75, 23);
            this.btnFindTimes.TabIndex = 27;
            this.btnFindTimes.Text = "Find Times";
            this.btnFindTimes.UseVisualStyleBackColor = true;
            this.btnFindTimes.Click += new System.EventHandler(this.BtnFindTimes_Click);
            // 
            // dgvAvailableTimes
            // 
            this.dgvAvailableTimes.AllowUserToAddRows = false;
            this.dgvAvailableTimes.AllowUserToDeleteRows = false;
            this.dgvAvailableTimes.AllowUserToResizeColumns = false;
            this.dgvAvailableTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTimes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAvailableTimes.Location = new System.Drawing.Point(344, 355);
            this.dgvAvailableTimes.MultiSelect = false;
            this.dgvAvailableTimes.Name = "dgvAvailableTimes";
            this.dgvAvailableTimes.RowHeadersVisible = false;
            this.dgvAvailableTimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAvailableTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableTimes.Size = new System.Drawing.Size(240, 173);
            this.dgvAvailableTimes.TabIndex = 28;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(509, 570);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 623);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvAvailableTimes);
            this.Controls.Add(this.btnFindTimes);
            this.Controls.Add(this.lblAvailableTimes);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioNinety);
            this.Controls.Add(this.radioSixty);
            this.Controls.Add(this.radioThirty);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtAptTitle);
            this.Controls.Add(this.lblApptTitle);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtConsultant);
            this.Controls.Add(this.lblConsultant);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblConsultant;
        private System.Windows.Forms.TextBox txtConsultant;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtAptTitle;
        private System.Windows.Forms.Label lblApptTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.RadioButton radioThirty;
        private System.Windows.Forms.RadioButton radioSixty;
        private System.Windows.Forms.RadioButton radioNinety;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label lblAvailableTimes;
        private System.Windows.Forms.Button btnFindTimes;
        private System.Windows.Forms.DataGridView dgvAvailableTimes;
        private System.Windows.Forms.Button btnSubmit;
    }
}
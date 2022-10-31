
namespace Scheduling_App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnModifyAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnModifyCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.clientscheduleEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAllAppointments = new System.Windows.Forms.Button();
            this.btnMonthAppointments = new System.Windows.Forms.Button();
            this.btnWeekAppointments = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientscheduleEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(7, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Schedule";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 109);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(1242, 203);
            this.dgvAppointments.TabIndex = 1;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 417);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1242, 203);
            this.dgvCustomers.TabIndex = 2;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(1179, 318);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAppointment.TabIndex = 3;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.BtnDeleteAppointment_Click);
            // 
            // btnModifyAppointment
            // 
            this.btnModifyAppointment.Location = new System.Drawing.Point(1098, 318);
            this.btnModifyAppointment.Name = "btnModifyAppointment";
            this.btnModifyAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnModifyAppointment.TabIndex = 4;
            this.btnModifyAppointment.Text = "Modify";
            this.btnModifyAppointment.UseVisualStyleBackColor = true;
            this.btnModifyAppointment.Click += new System.EventHandler(this.BtnModifyAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(1017, 318);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAppointment.TabIndex = 5;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(1017, 626);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnModifyCustomer
            // 
            this.btnModifyCustomer.Location = new System.Drawing.Point(1098, 626);
            this.btnModifyCustomer.Name = "btnModifyCustomer";
            this.btnModifyCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnModifyCustomer.TabIndex = 7;
            this.btnModifyCustomer.Text = "Modify";
            this.btnModifyCustomer.UseVisualStyleBackColor = true;
            this.btnModifyCustomer.Click += new System.EventHandler(this.BtnModifyCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1179, 626);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 6;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Location = new System.Drawing.Point(12, 90);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(71, 13);
            this.lblAppointments.TabIndex = 9;
            this.lblAppointments.Text = "Appointments";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(14, 401);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 10;
            this.lblCustomers.Text = "Customers";
            // 
            // clientscheduleEntitiesBindingSource
            // 
            this.clientscheduleEntitiesBindingSource.DataSource = typeof(Scheduling_App.client_scheduleEntities);
            // 
            // btnAllAppointments
            // 
            this.btnAllAppointments.Location = new System.Drawing.Point(1017, 80);
            this.btnAllAppointments.Name = "btnAllAppointments";
            this.btnAllAppointments.Size = new System.Drawing.Size(75, 23);
            this.btnAllAppointments.TabIndex = 13;
            this.btnAllAppointments.Text = "All";
            this.btnAllAppointments.UseVisualStyleBackColor = true;
            this.btnAllAppointments.Click += new System.EventHandler(this.BtnAllAppointments_Click);
            // 
            // btnMonthAppointments
            // 
            this.btnMonthAppointments.Location = new System.Drawing.Point(1098, 80);
            this.btnMonthAppointments.Name = "btnMonthAppointments";
            this.btnMonthAppointments.Size = new System.Drawing.Size(75, 23);
            this.btnMonthAppointments.TabIndex = 12;
            this.btnMonthAppointments.Text = "Month";
            this.btnMonthAppointments.UseVisualStyleBackColor = true;
            this.btnMonthAppointments.Click += new System.EventHandler(this.BtnMonthAppointments_Click);
            // 
            // btnWeekAppointments
            // 
            this.btnWeekAppointments.Location = new System.Drawing.Point(1179, 80);
            this.btnWeekAppointments.Name = "btnWeekAppointments";
            this.btnWeekAppointments.Size = new System.Drawing.Size(75, 23);
            this.btnWeekAppointments.TabIndex = 11;
            this.btnWeekAppointments.Text = "Week";
            this.btnWeekAppointments.UseVisualStyleBackColor = true;
            this.btnWeekAppointments.Click += new System.EventHandler(this.BtnWeekAppointments_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(1179, 23);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 14;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 697);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAllAppointments);
            this.Controls.Add(this.btnMonthAppointments);
            this.Controls.Add(this.btnWeekAppointments);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnModifyCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnModifyAppointment);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Client Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientscheduleEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.BindingSource clientscheduleEntitiesBindingSource;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnModifyAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnModifyCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnAllAppointments;
        private System.Windows.Forms.Button btnMonthAppointments;
        private System.Windows.Forms.Button btnWeekAppointments;
        private System.Windows.Forms.Button btnReports;
    }
}
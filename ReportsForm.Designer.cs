
namespace Scheduling_App
{
    partial class ReportsForm
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblTotalAppts = new System.Windows.Forms.Label();
            this.btnCountAppts = new System.Windows.Forms.Button();
            this.lblCountAppts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(35, 118);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(175, 118);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(38, 134);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(178, 134);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 4;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(175, 165);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Count: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(345, 78);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(380, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 8;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(348, 101);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(462, 240);
            this.dgvAppointments.TabIndex = 9;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(38, 160);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(735, 73);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lblTotalAppts
            // 
            this.lblTotalAppts.AutoSize = true;
            this.lblTotalAppts.Location = new System.Drawing.Point(35, 238);
            this.lblTotalAppts.Name = "lblTotalAppts";
            this.lblTotalAppts.Size = new System.Drawing.Size(98, 13);
            this.lblTotalAppts.TabIndex = 11;
            this.lblTotalAppts.Text = "Total Appointments";
            // 
            // btnCountAppts
            // 
            this.btnCountAppts.Location = new System.Drawing.Point(38, 254);
            this.btnCountAppts.Name = "btnCountAppts";
            this.btnCountAppts.Size = new System.Drawing.Size(75, 23);
            this.btnCountAppts.TabIndex = 13;
            this.btnCountAppts.Text = "Count";
            this.btnCountAppts.UseVisualStyleBackColor = true;
            this.btnCountAppts.Click += new System.EventHandler(this.BtnCountDay_Click);
            // 
            // lblCountAppts
            // 
            this.lblCountAppts.AutoSize = true;
            this.lblCountAppts.Location = new System.Drawing.Point(175, 238);
            this.lblCountAppts.Name = "lblCountAppts";
            this.lblCountAppts.Size = new System.Drawing.Size(38, 13);
            this.lblCountAppts.TabIndex = 14;
            this.lblCountAppts.Text = "Count:";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 401);
            this.Controls.Add(this.lblCountAppts);
            this.Controls.Add(this.btnCountAppts);
            this.Controls.Add(this.lblTotalAppts);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportsForm";
            this.Text = "Reports Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblTotalAppts;
        private System.Windows.Forms.Button btnCountAppts;
        private System.Windows.Forms.Label lblCountAppts;
    }
}
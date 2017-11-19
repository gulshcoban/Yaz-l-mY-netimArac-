namespace Yazılım_Test_Aracı
{
    partial class frmListOfProjects
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
            this.lblActivePerson = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblRequestMainProcess = new System.Windows.Forms.Label();
            this.dtGridProjects = new System.Windows.Forms.DataGridView();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivePerson
            // 
            this.lblActivePerson.AutoSize = true;
            this.lblActivePerson.Location = new System.Drawing.Point(837, 9);
            this.lblActivePerson.Name = "lblActivePerson";
            this.lblActivePerson.Size = new System.Drawing.Size(0, 17);
            this.lblActivePerson.TabIndex = 17;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(840, 46);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 37);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblRequestMainProcess
            // 
            this.lblRequestMainProcess.AutoSize = true;
            this.lblRequestMainProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestMainProcess.Location = new System.Drawing.Point(52, 63);
            this.lblRequestMainProcess.Name = "lblRequestMainProcess";
            this.lblRequestMainProcess.Size = new System.Drawing.Size(624, 20);
            this.lblRequestMainProcess.TabIndex = 15;
            this.lblRequestMainProcess.Text = "In the following projects, select the one you want to add main process to.";
            // 
            // dtGridProjects
            // 
            this.dtGridProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectNo,
            this.ProjectName,
            this.StartDate,
            this.FinishDate,
            this.Budget,
            this.isActive,
            this.CustomerName});
            this.dtGridProjects.Location = new System.Drawing.Point(46, 105);
            this.dtGridProjects.Name = "dtGridProjects";
            this.dtGridProjects.RowTemplate.Height = 24;
            this.dtGridProjects.Size = new System.Drawing.Size(910, 317);
            this.dtGridProjects.TabIndex = 14;
            this.dtGridProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProjects_CellClick);
            // 
            // ProjectNo
            // 
            this.ProjectNo.HeaderText = "Project No";
            this.ProjectNo.Name = "ProjectNo";
            this.ProjectNo.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // FinishDate
            // 
            this.FinishDate.HeaderText = "Finish Date";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.ReadOnly = true;
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Budget";
            this.Budget.Name = "Budget";
            this.Budget.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "is Active";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // frmListOfProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 445);
            this.Controls.Add(this.lblActivePerson);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRequestMainProcess);
            this.Controls.Add(this.dtGridProjects);
            this.Name = "frmListOfProjects";
            this.Text = "ListOfProjects";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListOfProjects_FormClosing);
            this.Load += new System.EventHandler(this.frmListOfProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivePerson;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblRequestMainProcess;
        private System.Windows.Forms.DataGridView dtGridProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
    }
}
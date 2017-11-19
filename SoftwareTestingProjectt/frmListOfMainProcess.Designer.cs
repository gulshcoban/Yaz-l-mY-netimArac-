namespace SoftwareTestingProjectt
{
    partial class frmListOfMainProcess
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
            this.btnInsertMainProcess = new System.Windows.Forms.Button();
            this.dtGridMainProcess = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupOfProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanFinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRequestProcess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMainProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertMainProcess
            // 
            this.btnInsertMainProcess.Location = new System.Drawing.Point(30, 12);
            this.btnInsertMainProcess.Name = "btnInsertMainProcess";
            this.btnInsertMainProcess.Size = new System.Drawing.Size(146, 49);
            this.btnInsertMainProcess.TabIndex = 0;
            this.btnInsertMainProcess.Text = "INSERT MAIN PROCESS";
            this.btnInsertMainProcess.UseVisualStyleBackColor = true;
            this.btnInsertMainProcess.Click += new System.EventHandler(this.btnInsertMainProcess_Click);
            // 
            // dtGridMainProcess
            // 
            this.dtGridMainProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMainProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.RequestDate,
            this.DateOfAppointment,
            this.Complete,
            this.GroupOfProject,
            this.Requester,
            this.Group,
            this.Unit,
            this.State,
            this.Priority,
            this.PlanStartDate,
            this.PlanFinishDate});
            this.dtGridMainProcess.Location = new System.Drawing.Point(12, 131);
            this.dtGridMainProcess.Name = "dtGridMainProcess";
            this.dtGridMainProcess.RowTemplate.Height = 24;
            this.dtGridMainProcess.Size = new System.Drawing.Size(1245, 401);
            this.dtGridMainProcess.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "Request Date";
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.HeaderText = "Date Of Appointment";
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.ReadOnly = true;
            // 
            // Complete
            // 
            this.Complete.HeaderText = "Complete";
            this.Complete.Name = "Complete";
            this.Complete.ReadOnly = true;
            // 
            // GroupOfProject
            // 
            this.GroupOfProject.HeaderText = "Group Of Project";
            this.GroupOfProject.Name = "GroupOfProject";
            this.GroupOfProject.ReadOnly = true;
            // 
            // Requester
            // 
            this.Requester.HeaderText = "Requester";
            this.Requester.Name = "Requester";
            this.Requester.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // PlanStartDate
            // 
            this.PlanStartDate.HeaderText = "Plan Startdate";
            this.PlanStartDate.Name = "PlanStartDate";
            this.PlanStartDate.ReadOnly = true;
            // 
            // PlanFinishDate
            // 
            this.PlanFinishDate.HeaderText = "Plan Finishdate";
            this.PlanFinishDate.Name = "PlanFinishDate";
            this.PlanFinishDate.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(205, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 48);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRequestProcess
            // 
            this.lblRequestProcess.AutoSize = true;
            this.lblRequestProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestProcess.Location = new System.Drawing.Point(26, 88);
            this.lblRequestProcess.Name = "lblRequestProcess";
            this.lblRequestProcess.Size = new System.Drawing.Size(643, 20);
            this.lblRequestProcess.TabIndex = 4;
            this.lblRequestProcess.Text = "In the following main processes, select the one you want to add process to.";
            this.lblRequestProcess.Click += new System.EventHandler(this.lblRequestProcess_Click);
            // 
            // frmListOfMainProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 544);
            this.Controls.Add(this.lblRequestProcess);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtGridMainProcess);
            this.Controls.Add(this.btnInsertMainProcess);
            this.Name = "frmListOfMainProcess";
            this.Text = "List Of Main Process";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMainProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertMainProcess;
        private System.Windows.Forms.DataGridView dtGridMainProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupOfProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanFinishDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRequestProcess;
    }
}
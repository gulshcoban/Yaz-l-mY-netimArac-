namespace Yazılım_Test_Aracı
{
    partial class frmListOfUserWorkFollow
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
            this.dtGridWorkFollow = new System.Windows.Forms.DataGridView();
            this.WorkFollowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkFollowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridWorkFollow)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridWorkFollow
            // 
            this.dtGridWorkFollow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridWorkFollow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkFollowID,
            this.ProcessID,
            this.StartDate,
            this.FinishDate,
            this.UserID,
            this.CompleteRate,
            this.WorkFollowName});
            this.dtGridWorkFollow.Location = new System.Drawing.Point(26, 80);
            this.dtGridWorkFollow.Name = "dtGridWorkFollow";
            this.dtGridWorkFollow.RowTemplate.Height = 24;
            this.dtGridWorkFollow.Size = new System.Drawing.Size(835, 259);
            this.dtGridWorkFollow.TabIndex = 0;
            // 
            // WorkFollowID
            // 
            this.WorkFollowID.HeaderText = "WorkFollowID";
            this.WorkFollowID.Name = "WorkFollowID";
            this.WorkFollowID.ReadOnly = true;
            // 
            // ProcessID
            // 
            this.ProcessID.HeaderText = "ProcessID";
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // FinishDate
            // 
            this.FinishDate.HeaderText = "Finish Date ";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // CompleteRate
            // 
            this.CompleteRate.HeaderText = "CompleteRate";
            this.CompleteRate.Name = "CompleteRate";
            this.CompleteRate.ReadOnly = true;
            // 
            // WorkFollowName
            // 
            this.WorkFollowName.HeaderText = "Work Follow Name";
            this.WorkFollowName.Name = "WorkFollowName";
            this.WorkFollowName.ReadOnly = true;
            // 
            // frmListOfUserWorkFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 362);
            this.Controls.Add(this.dtGridWorkFollow);
            this.Name = "frmListOfUserWorkFollow";
            this.Text = "ListOfUserWorkFollow";
            this.Load += new System.EventHandler(this.ListOfUserWorkFollow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridWorkFollow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridWorkFollow;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkFollowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkFollowName;
    }
}
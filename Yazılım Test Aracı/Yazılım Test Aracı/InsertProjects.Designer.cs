namespace Yazılım_Test_Aracı
{
    partial class frmInsertProjects
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblActivePerson = new System.Windows.Forms.Label();
            this.dtTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.dtTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblisActive = new System.Windows.Forms.Label();
            this.cmbisActive = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(275, 48);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 32);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblActivePerson
            // 
            this.lblActivePerson.AutoSize = true;
            this.lblActivePerson.Location = new System.Drawing.Point(281, 19);
            this.lblActivePerson.Name = "lblActivePerson";
            this.lblActivePerson.Size = new System.Drawing.Size(0, 17);
            this.lblActivePerson.TabIndex = 32;
            // 
            // dtTimeFinish
            // 
            this.dtTimeFinish.Location = new System.Drawing.Point(168, 252);
            this.dtTimeFinish.Name = "dtTimeFinish";
            this.dtTimeFinish.Size = new System.Drawing.Size(200, 22);
            this.dtTimeFinish.TabIndex = 26;
            // 
            // dtTimeStart
            // 
            this.dtTimeStart.Location = new System.Drawing.Point(168, 199);
            this.dtTimeStart.Name = "dtTimeStart";
            this.dtTimeStart.Size = new System.Drawing.Size(200, 22);
            this.dtTimeStart.TabIndex = 25;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(168, 147);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 22);
            this.txtBudget.TabIndex = 24;
            this.txtBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudget_KeyPress);
            this.txtBudget.Leave += new System.EventHandler(this.txtBudget_Leave);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(168, 91);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 22);
            this.txtProjectName.TabIndex = 23;
            this.txtProjectName.Leave += new System.EventHandler(this.txtProjectName_Leave);
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(49, 252);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(83, 17);
            this.lblFinishDate.TabIndex = 31;
            this.lblFinishDate.Text = "Finish Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(49, 199);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 30;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(49, 147);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(57, 17);
            this.lblBudget.TabIndex = 29;
            this.lblBudget.Text = "Budget:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(49, 91);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(97, 17);
            this.lblProjectName.TabIndex = 28;
            this.lblProjectName.Text = "Project Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(168, 369);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblisActive
            // 
            this.lblisActive.AutoSize = true;
            this.lblisActive.Location = new System.Drawing.Point(40, 310);
            this.lblisActive.Name = "lblisActive";
            this.lblisActive.Size = new System.Drawing.Size(124, 17);
            this.lblisActive.TabIndex = 33;
            this.lblisActive.Text = "Is Project Active ? ";
            // 
            // cmbisActive
            // 
            this.cmbisActive.FormattingEnabled = true;
            this.cmbisActive.Location = new System.Drawing.Point(168, 307);
            this.cmbisActive.Name = "cmbisActive";
            this.cmbisActive.Size = new System.Drawing.Size(200, 24);
            this.cmbisActive.TabIndex = 34;
            // 
            // frmInsertProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 409);
            this.Controls.Add(this.cmbisActive);
            this.Controls.Add(this.lblisActive);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblActivePerson);
            this.Controls.Add(this.dtTimeFinish);
            this.Controls.Add(this.dtTimeStart);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblFinishDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmInsertProjects";
            this.Text = "InsertProjects";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInsertProjects_FormClosing);
            this.Load += new System.EventHandler(this.frmInsertProjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblActivePerson;
        private System.Windows.Forms.DateTimePicker dtTimeFinish;
        private System.Windows.Forms.DateTimePicker dtTimeStart;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblisActive;
        private System.Windows.Forms.ComboBox cmbisActive;
    }
}
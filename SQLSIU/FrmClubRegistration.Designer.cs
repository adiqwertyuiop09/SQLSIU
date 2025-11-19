namespace SQLSIU
{
    partial class FrmClubRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.studTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.programCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mnTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dgvClubMembers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // studTxt
            // 
            this.studTxt.Location = new System.Drawing.Point(159, 75);
            this.studTxt.Name = "studTxt";
            this.studTxt.Size = new System.Drawing.Size(100, 20);
            this.studTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // lnTxt
            // 
            this.lnTxt.Location = new System.Drawing.Point(159, 145);
            this.lnTxt.Name = "lnTxt";
            this.lnTxt.Size = new System.Drawing.Size(100, 20);
            this.lnTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(159, 220);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(100, 20);
            this.ageTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name:";
            // 
            // fnTxt
            // 
            this.fnTxt.Location = new System.Drawing.Point(324, 145);
            this.fnTxt.Name = "fnTxt";
            this.fnTxt.Size = new System.Drawing.Size(100, 20);
            this.fnTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender:";
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCombo.Location = new System.Drawing.Point(324, 220);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(121, 21);
            this.genderCombo.TabIndex = 9;
            // 
            // programCombo
            // 
            this.programCombo.FormattingEnabled = true;
            this.programCombo.Items.AddRange(new object[] {
            "Bachelor of Science in Information Technology (BSIT)",
            "Bachelor of Science in Computer Science (BSCS)",
            "Bachelor of Science in Information Systems (BSIS)",
            "Bachelor of Science in Computer Engineering (BSCpE)",
            "Bachelor of Science in Electronics Engineering (BSECE)",
            "Bachelor of Science in Electrical Engineering (BSEE)",
            "Bachelor of Science in Civil Engineering (BSCE)",
            "Bachelor of Science in Mechanical Engineering (BSME)",
            "Bachelor of Science in Architecture",
            "Bachelor of Science in Criminology",
            "Bachelor of Science in Nursing (BSN)",
            "Bachelor of Science in Medical Technology (BSMT)",
            "Bachelor of Science in Pharmacy",
            "Bachelor of Science in Psychology (BSPsych)",
            "Bachelor of Elementary Education (BEEd)",
            "Bachelor of Secondary Education (BSEd)",
            "Bachelor of Science in Business Administration (BSBA)",
            "Bachelor of Science in Accountancy (BSA)",
            "Bachelor of Science in Hospitality Management (BSHM)",
            "Bachelor of Science in Tourism Management (BSTM)",
            "Bachelor of Arts in Communication",
            "Bachelor of Arts in Political Science",
            "Bachelor of Arts in English",
            "Bachelor of Science in Biology (BSBio)",
            "Bachelor of Science in Mathematics (BSMath)",
            "Bachelor of Science in Entrepreneurship",
            "Bachelor of Science in Social Work"});
            this.programCombo.Location = new System.Drawing.Point(504, 75);
            this.programCombo.Name = "programCombo";
            this.programCombo.Size = new System.Drawing.Size(121, 21);
            this.programCombo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Program:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Middle Name:";
            // 
            // mnTxt
            // 
            this.mnTxt.Location = new System.Drawing.Point(504, 145);
            this.mnTxt.Name = "mnTxt";
            this.mnTxt.Size = new System.Drawing.Size(100, 20);
            this.mnTxt.TabIndex = 13;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(766, 72);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(89, 35);
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(766, 129);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 35);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dgvClubMembers
            // 
            this.dgvClubMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubMembers.Location = new System.Drawing.Point(159, 381);
            this.dgvClubMembers.Name = "dgvClubMembers";
            this.dgvClubMembers.Size = new System.Drawing.Size(538, 171);
            this.dgvClubMembers.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = " List of Club Members";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(766, 381);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(89, 35);
            this.refreshBtn.TabIndex = 18;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 739);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvClubMembers);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.mnTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.programCombo);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fnTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studTxt);
            this.Controls.Add(this.label1);
            this.Name = "FrmClubRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.ComboBox programCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mnTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dgvClubMembers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refreshBtn;
    }
}


namespace SQLSIU
{
    partial class FrmUpdateMember
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtln = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.comboprogram = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studCombo = new System.Windows.Forms.ComboBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtln
            // 
            this.txtln.Location = new System.Drawing.Point(141, 126);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(100, 20);
            this.txtln.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name:";
            // 
            // txtfn
            // 
            this.txtfn.Location = new System.Drawing.Point(141, 194);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(100, 20);
            this.txtfn.TabIndex = 5;
            // 
            // txtmn
            // 
            this.txtmn.Location = new System.Drawing.Point(141, 261);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(100, 20);
            this.txtmn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Name:";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(141, 324);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender:";
            // 
            // combogender
            // 
            this.combogender.FormattingEnabled = true;
            this.combogender.Location = new System.Drawing.Point(141, 390);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(121, 21);
            this.combogender.TabIndex = 11;
            // 
            // comboprogram
            // 
            this.comboprogram.FormattingEnabled = true;
            this.comboprogram.Location = new System.Drawing.Point(141, 456);
            this.comboprogram.Name = "comboprogram";
            this.comboprogram.Size = new System.Drawing.Size(121, 21);
            this.comboprogram.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Program:";
            // 
            // studCombo
            // 
            this.studCombo.FormattingEnabled = true;
            this.studCombo.Location = new System.Drawing.Point(141, 69);
            this.studCombo.Name = "studCombo";
            this.studCombo.Size = new System.Drawing.Size(121, 21);
            this.studCombo.TabIndex = 14;
            this.studCombo.SelectedIndexChanged += new System.EventHandler(this.studCombo_SelectedIndexChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(166, 513);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 15;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 693);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.studCombo);
            this.Controls.Add(this.comboprogram);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.ComboBox comboprogram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox studCombo;
        private System.Windows.Forms.Button confirmBtn;
    }
}
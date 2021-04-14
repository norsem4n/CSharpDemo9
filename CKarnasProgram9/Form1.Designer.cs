namespace CKarnasProgram9
{
    partial class Form1
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
            this.lblConferenceName = new System.Windows.Forms.Label();
            this.txtConferenceName = new System.Windows.Forms.TextBox();
            this.nudAttendees = new System.Windows.Forms.NumericUpDown();
            this.nudNights = new System.Windows.Forms.NumericUpDown();
            this.lblAttendees = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.grpboxAccommodation = new System.Windows.Forms.GroupBox();
            this.radiobuttonSuite = new System.Windows.Forms.RadioButton();
            this.radiobuttonDouble = new System.Windows.Forms.RadioButton();
            this.radiobuttonSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxRec = new System.Windows.Forms.CheckBox();
            this.chkboxInternet = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCharges = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttendees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNights)).BeginInit();
            this.grpboxAccommodation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed by CGK";
            // 
            // lblConferenceName
            // 
            this.lblConferenceName.AutoSize = true;
            this.lblConferenceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConferenceName.Location = new System.Drawing.Point(73, 38);
            this.lblConferenceName.Name = "lblConferenceName";
            this.lblConferenceName.Size = new System.Drawing.Size(170, 24);
            this.lblConferenceName.TabIndex = 1;
            this.lblConferenceName.Text = "Conference Name:";
            // 
            // txtConferenceName
            // 
            this.txtConferenceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConferenceName.Location = new System.Drawing.Point(262, 35);
            this.txtConferenceName.Name = "txtConferenceName";
            this.txtConferenceName.Size = new System.Drawing.Size(329, 29);
            this.txtConferenceName.TabIndex = 2;
            // 
            // nudAttendees
            // 
            this.nudAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAttendees.Location = new System.Drawing.Point(262, 75);
            this.nudAttendees.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAttendees.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAttendees.Name = "nudAttendees";
            this.nudAttendees.Size = new System.Drawing.Size(89, 29);
            this.nudAttendees.TabIndex = 3;
            this.nudAttendees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAttendees.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudNights
            // 
            this.nudNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNights.Location = new System.Drawing.Point(262, 119);
            this.nudNights.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNights.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNights.Name = "nudNights";
            this.nudNights.Size = new System.Drawing.Size(89, 29);
            this.nudNights.TabIndex = 4;
            this.nudNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNights.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblAttendees
            // 
            this.lblAttendees.AutoSize = true;
            this.lblAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendees.Location = new System.Drawing.Point(49, 77);
            this.lblAttendees.Name = "lblAttendees";
            this.lblAttendees.Size = new System.Drawing.Size(194, 24);
            this.lblAttendees.TabIndex = 5;
            this.lblAttendees.Text = "Number of Attendees:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(81, 121);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(162, 24);
            this.lblNights.TabIndex = 6;
            this.lblNights.Text = "Number of Nights:";
            // 
            // grpboxAccommodation
            // 
            this.grpboxAccommodation.Controls.Add(this.radiobuttonSuite);
            this.grpboxAccommodation.Controls.Add(this.radiobuttonDouble);
            this.grpboxAccommodation.Controls.Add(this.radiobuttonSingle);
            this.grpboxAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAccommodation.Location = new System.Drawing.Point(85, 163);
            this.grpboxAccommodation.Name = "grpboxAccommodation";
            this.grpboxAccommodation.Size = new System.Drawing.Size(236, 139);
            this.grpboxAccommodation.TabIndex = 7;
            this.grpboxAccommodation.TabStop = false;
            this.grpboxAccommodation.Text = "Accommodation Type";
            // 
            // radiobuttonSuite
            // 
            this.radiobuttonSuite.AutoSize = true;
            this.radiobuttonSuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonSuite.Location = new System.Drawing.Point(6, 96);
            this.radiobuttonSuite.Name = "radiobuttonSuite";
            this.radiobuttonSuite.Size = new System.Drawing.Size(70, 28);
            this.radiobuttonSuite.TabIndex = 2;
            this.radiobuttonSuite.Text = "Suite";
            this.radiobuttonSuite.UseVisualStyleBackColor = true;
            // 
            // radiobuttonDouble
            // 
            this.radiobuttonDouble.AutoSize = true;
            this.radiobuttonDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonDouble.Location = new System.Drawing.Point(6, 62);
            this.radiobuttonDouble.Name = "radiobuttonDouble";
            this.radiobuttonDouble.Size = new System.Drawing.Size(89, 28);
            this.radiobuttonDouble.TabIndex = 1;
            this.radiobuttonDouble.Text = "Double";
            this.radiobuttonDouble.UseVisualStyleBackColor = true;
            // 
            // radiobuttonSingle
            // 
            this.radiobuttonSingle.AutoSize = true;
            this.radiobuttonSingle.Checked = true;
            this.radiobuttonSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonSingle.Location = new System.Drawing.Point(6, 28);
            this.radiobuttonSingle.Name = "radiobuttonSingle";
            this.radiobuttonSingle.Size = new System.Drawing.Size(81, 28);
            this.radiobuttonSingle.TabIndex = 0;
            this.radiobuttonSingle.TabStop = true;
            this.radiobuttonSingle.Text = "Single";
            this.radiobuttonSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkboxRec);
            this.groupBox1.Controls.Add(this.chkboxInternet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(345, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optional Services";
            // 
            // chkboxRec
            // 
            this.chkboxRec.AutoSize = true;
            this.chkboxRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxRec.Location = new System.Drawing.Point(17, 73);
            this.chkboxRec.Name = "chkboxRec";
            this.chkboxRec.Size = new System.Drawing.Size(191, 28);
            this.chkboxRec.TabIndex = 1;
            this.chkboxRec.Text = "Rec Center Access";
            this.chkboxRec.UseVisualStyleBackColor = true;
            // 
            // chkboxInternet
            // 
            this.chkboxInternet.AutoSize = true;
            this.chkboxInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxInternet.Location = new System.Drawing.Point(17, 39);
            this.chkboxInternet.Name = "chkboxInternet";
            this.chkboxInternet.Size = new System.Drawing.Size(158, 28);
            this.chkboxInternet.TabIndex = 0;
            this.chkboxInternet.Text = "Internet Access";
            this.chkboxInternet.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(39, 405);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(236, 44);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Conference";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(39, 465);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(236, 44);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Modify Conference";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(39, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 44);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(167, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCharges
            // 
            this.lblCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharges.Location = new System.Drawing.Point(296, 393);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(397, 189);
            this.lblCharges.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.grpboxAccommodation);
            this.groupBox2.Controls.Add(this.lblNights);
            this.groupBox2.Controls.Add(this.lblAttendees);
            this.groupBox2.Controls.Add(this.nudNights);
            this.groupBox2.Controls.Add(this.nudAttendees);
            this.groupBox2.Controls.Add(this.txtConferenceName);
            this.groupBox2.Controls.Add(this.lblConferenceName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 308);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conference Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "CSU Conference Services - Charges Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program 9 - CSU Conference Services ";
            ((System.ComponentModel.ISupportInitialize)(this.nudAttendees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNights)).EndInit();
            this.grpboxAccommodation.ResumeLayout(false);
            this.grpboxAccommodation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConferenceName;
        private System.Windows.Forms.TextBox txtConferenceName;
        private System.Windows.Forms.NumericUpDown nudAttendees;
        private System.Windows.Forms.NumericUpDown nudNights;
        private System.Windows.Forms.Label lblAttendees;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.GroupBox grpboxAccommodation;
        private System.Windows.Forms.RadioButton radiobuttonSuite;
        private System.Windows.Forms.RadioButton radiobuttonDouble;
        private System.Windows.Forms.RadioButton radiobuttonSingle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxRec;
        private System.Windows.Forms.CheckBox chkboxInternet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}


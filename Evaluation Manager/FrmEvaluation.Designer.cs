namespace Evaluation_Manager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lblMinForSignature = new System.Windows.Forms.Label();
            this.lblMinForGrade = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblEvaluationDate = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(12, 52);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(776, 292);
            this.txtActivityDescription.TabIndex = 0;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(421, 26);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 2;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(527, 26);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 3;
            this.txtMinForGrade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(333, 365);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 4;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(440, 365);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
            this.txtEvaluationDate.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(621, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(13, 26);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(309, 21);
            this.cboActivities.TabIndex = 8;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(10, 10);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(51, 13);
            this.lblActivity.TabIndex = 9;
            this.lblActivity.Text = "Aktivnost";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(621, 365);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 20);
            this.numPoints.TabIndex = 10;
            // 
            // lblMinForSignature
            // 
            this.lblMinForSignature.AutoSize = true;
            this.lblMinForSignature.Location = new System.Drawing.Point(418, 9);
            this.lblMinForSignature.Name = "lblMinForSignature";
            this.lblMinForSignature.Size = new System.Drawing.Size(72, 13);
            this.lblMinForSignature.TabIndex = 11;
            this.lblMinForSignature.Text = "Min. za potpis";
            this.lblMinForSignature.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinForGrade
            // 
            this.lblMinForGrade.AutoSize = true;
            this.lblMinForGrade.Location = new System.Drawing.Point(524, 10);
            this.lblMinForGrade.Name = "lblMinForGrade";
            this.lblMinForGrade.Size = new System.Drawing.Size(76, 13);
            this.lblMinForGrade.TabIndex = 12;
            this.lblMinForGrade.Text = "Min. za ocjenu";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(330, 349);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(57, 13);
            this.lblTeacher.TabIndex = 13;
            this.lblTeacher.Text = "Ocjenjivač";
            // 
            // lblEvaluationDate
            // 
            this.lblEvaluationDate.AutoSize = true;
            this.lblEvaluationDate.Location = new System.Drawing.Point(437, 349);
            this.lblEvaluationDate.Name = "lblEvaluationDate";
            this.lblEvaluationDate.Size = new System.Drawing.Size(89, 13);
            this.lblEvaluationDate.TabIndex = 14;
            this.lblEvaluationDate.Text = "Datum evaluacije";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(618, 349);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(40, 13);
            this.lblPoints.TabIndex = 15;
            this.lblPoints.Text = "Bodovi";
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblEvaluationDate);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblMinForGrade);
            this.Controls.Add(this.lblMinForSignature);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.txtActivityDescription);
            this.Name = "FrmEvaluation";
            this.Text = "Forma za evaluaciju";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lblMinForSignature;
        private System.Windows.Forms.Label lblMinForGrade;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblEvaluationDate;
        private System.Windows.Forms.Label lblPoints;
    }
}
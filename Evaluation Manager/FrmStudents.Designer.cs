namespace Evaluation_Manager
{
    partial class FrmStudents
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
            this.btnEvaluteStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvaluteStudent
            // 
            this.btnEvaluteStudent.Location = new System.Drawing.Point(584, 384);
            this.btnEvaluteStudent.Name = "btnEvaluteStudent";
            this.btnEvaluteStudent.Size = new System.Drawing.Size(107, 23);
            this.btnEvaluteStudent.TabIndex = 0;
            this.btnEvaluteStudent.Text = "Evaluiraj studenta";
            this.btnEvaluteStudent.UseVisualStyleBackColor = true;
            this.btnEvaluteStudent.Click += new System.EventHandler(this.btnEvaluteStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(28, 21);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(663, 343);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(481, 384);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(97, 23);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generiraj report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 419);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnEvaluteStudent);
            this.Name = "FrmStudents";
            this.Text = "FrmStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluteStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
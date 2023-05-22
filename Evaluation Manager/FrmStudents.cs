using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void btnEvaluteStudent_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent != null)
            {
                FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }

        private void btnGenerateRepoort_Click(object sender, Event)

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e) {
            var form = new FrmFinalReport();
            form.ShowDialog();
        }
    }
}

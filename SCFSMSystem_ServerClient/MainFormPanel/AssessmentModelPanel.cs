using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCFSMSystem_ServerClient.MainFormPanel
{
    public partial class AssessmentModelPanel : Form
    {
        public AssessmentModelPanel()
        {
            InitializeComponent();
        }

        private void AssessmentModelPanel_Load(object sender, EventArgs e)
        {

        }

        private void OpAssessmentModeForm_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Model.StaticForm.AssessmentModelForm == null)
            {
                AssessmentModelForm.AssessmentModelForm modelForm = new AssessmentModelForm.AssessmentModelForm();
                modelForm.Show();
            }
            else
            {
                Model.StaticForm.AssessmentModelForm.Show();
            }
            Model.StaticForm.MainForm.Hide();
            this.Cursor = Cursors.Arrow;
        }
    }
}

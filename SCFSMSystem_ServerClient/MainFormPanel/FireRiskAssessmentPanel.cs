using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCFSMSystem_ServerClient.Model;

namespace SCFSMSystem_ServerClient.MainFormPanel
{
    public partial class FireRiskAssessmentPanel : Form
    {
        public FireRiskAssessmentPanel()
        {
            InitializeComponent();
        }

        private void OpFireRiskAssessmentForm_Click(object sender, EventArgs e)
        {
            if (StaticForm.GisForm == null)
            {
                StaticForm.GisForm = new GisFrm();
                StaticForm.GisForm.Show();
            }
            else
            {
                StaticForm.GisForm.Show();
            }
            StaticForm.MainForm.Hide();
        }
    }
}

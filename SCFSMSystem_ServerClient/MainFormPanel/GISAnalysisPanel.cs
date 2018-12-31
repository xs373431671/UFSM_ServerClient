using SCFSMSystem_ServerClient.Model;
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
    public partial class GISAnalysisPanel : Form
    {
        public GISAnalysisPanel()
        {
            InitializeComponent();
        }

        private void OpGISAnalysisForm_Click(object sender, EventArgs e)
        {
          
            this.Cursor = Cursors.WaitCursor;
            if (StaticForm.GisAnalysisForm == null)
            {
                StaticForm.GisAnalysisForm = new GISAnalysis.GISAnalysis();
                StaticForm.GisAnalysisForm.Show();
            }
            else
            {
                StaticForm.GisAnalysisForm.Show();
            }
            StaticForm.MainForm.Hide();
            this.Cursor = Cursors.Arrow;       
        }
    }
}

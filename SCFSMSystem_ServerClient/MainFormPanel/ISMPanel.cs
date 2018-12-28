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
    public partial class ISMPanel : Form
    {
        public ISMPanel()
        {
            InitializeComponent();
        }

        private void ISMPanel_Load(object sender, EventArgs e)
        {

        }

        private void OpIsmFormBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Model.StaticForm.ISMForm == null)
            {
                ISM.ISMForm1 ismForm = new ISM.ISMForm1();
                ismForm.Show();
            }
            else
            {
                Model.StaticForm.ISMForm.Show();
            }
            Model.StaticForm.MainForm.Hide();
            this.Cursor = Cursors.Arrow;
        }
    }
}

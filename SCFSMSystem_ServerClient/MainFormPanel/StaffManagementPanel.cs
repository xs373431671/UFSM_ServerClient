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
    public partial class StaffManagementPanel : Form
    {
        public StaffManagementPanel()
        {
            InitializeComponent();
        }

        private void OpIsmFormBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Model.StaticForm.StaffForm == null)
            {
                Model.StaticForm.StaffForm = new StaffManagementForm.StaffManagementForm();
                Model.StaticForm.StaffForm.Show();
            }
            else
            {
                Model.StaticForm.StaffForm.Show();
            }
            Model.StaticForm.MainForm.Hide();
            this.Cursor = Cursors.Arrow;

           
            
        }
    }
}

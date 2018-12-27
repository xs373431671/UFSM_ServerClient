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
            Model.StaticForm.StaffForm = new StaffManagementForm.StaffManagementForm();
            Model.StaticForm.MainForm.Hide();
            Model.StaticForm.StaffForm.Show();
        }
    }
}

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

namespace SCFSMSystem_ServerClient.GISAnalysis
{
    public partial class HazardSourceSettingForm : Form
    {
        public HazardSourceSettingForm(SetTextValue s)
        {
            InitializeComponent();
            ss = s;
            
        }
        private SetTextValue ss = null;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Visible = false;
                }
                if(c is ComboBox)
                {
                    c.Visible = false;
                }
            }

            for(int i=1;i<=a;i++)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Name == string.Format("textBox{0}",i)|| c.Name == string.Format("textBox{0}", i+20))
                        { c.Visible = true; }
                    }
                    if (c is ComboBox)
                    {
                        if (c.Name == string.Format("comboBox{0}", i))
                        { c.Visible = true; }
                    }
                }
            }
            textBox41.Visible = true;

        }

        private void HazardSourceSettingForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "0";
                    c.Visible = false;
                }
                if (c is ComboBox)
                {
                    foreach (string s in StaticObject.efficiencyFactor_3Percent)
                    {
                        (c as ComboBox).Items.Add(s);
                    }
                    foreach (string s in StaticObject.efficiencyFactor_6Percent)
                    {
                        (c as ComboBox).Items.Add(s);
                    }
                    foreach (string s in StaticObject.efficiencyFactor_19Percent)
                    {
                        (c as ComboBox).Items.Add(s);
                    }
                    (c as ComboBox).SelectedItem = (c as ComboBox).Items[0];
                    c.Visible = false;
                }
            }
            this.numericUpDown1.Value = 1;
            comboBox1.Visible = true;
            textBox1.Visible = true;
            textBox21.Visible = true;
            textBox41.Visible = true;
            textBox41.Text = "0";
            
        }

        #region 点击窗体任意处移动窗体
        private System.Drawing.Point offset;
        private void GISAnalysis_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            System.Drawing.Point cur = this.PointToScreen(e.Location);
            offset = new System.Drawing.Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void GISAnalysis_MouseMove(object sender, MouseEventArgs e)
        {

            if (MouseButtons.Left != e.Button) return;
            System.Drawing.Point cur = MousePosition;
            this.Location = new System.Drawing.Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.GisAnalysisForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = (int)numericUpDown1.Value;

                double quality = double.Parse(textBox41.Text);
                if (quality <= 0)
                {
                    MessageBox.Show("请填入燃料总质量！");
                    return;
                }


                double TNT_Equivalent = 0;

                for (int i = 1; i <= number; i++)
                {
                    double a = 0;//效率因子；
                    double wf = 0;//某危险源的相对质量；
                    double qf = 0;//某危险源的燃烧热
                    int qTNT = 4520;//TNT的爆炸热（j/kg）

                    foreach (Control c in this.Controls)
                    {
                        if (c.Name == string.Format("comboBox{0}", i))
                        {
                            if (StaticObject.efficiencyFactor_3Percent.Contains((c as ComboBox).SelectedItem.ToString()))
                            { a = 0.03; }
                            if (StaticObject.efficiencyFactor_6Percent.Contains((c as ComboBox).SelectedItem.ToString()))
                            { a = 0.06; }
                            if (StaticObject.efficiencyFactor_19Percent.Contains((c as ComboBox).SelectedItem.ToString()))
                            { a = 0.19; }
                        }


                        if (c.Name == string.Format("textBox{0}", i))
                        {
                            qf = double.Parse(c.Text);
                        }
                        if (c.Name == string.Format("textBox{0}", i + 20))
                        {
                            wf = (double.Parse(c.Text) / 100) * quality;
                        }

                        TNT_Equivalent += a * wf * qf / qTNT;
                    }
                }
                ss(TNT_Equivalent);
                this.Hide();
                StaticForm.GisAnalysisForm.Show();
            }
            catch
            {
                MessageBox.Show("数据格式错误，请检查修正后重试！");
            }                      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.GisAnalysisForm.Show();
        }
    }
}

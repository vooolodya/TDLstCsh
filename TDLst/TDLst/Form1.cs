using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TDLst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form1StartSize();
        }

        private void Form1StartSize()
        {
            double k = menuPanel.Width;
            menuPanel.Width = Convert.ToInt32(SystemParameters.FullPrimaryScreenWidth * 0.25);
            k = k / menuPanel.Width;

            menuPanel.Width = Convert.ToInt32(menuPanel.Width * k);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            dGVListTasks.Rows.Add(false, taskField.Text);
            taskField.Text = string.Empty;
             
        }
    }
}

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpFinalProject
{
    public partial class sysman : Form
    {
        public sysman()
        {
            InitializeComponent();
        }
        private void sysman_Load(object sender, EventArgs e)
        {

        }


        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}");
        }
        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcKill window = new ProcKill();
            window.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About window = new About();
            window.Show();
        }

        private void killBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

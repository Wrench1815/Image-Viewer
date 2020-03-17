using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog()== DialogResult.OK )
			{
				pictureBox1.Load(openFileDialog1.FileName);
			}
		}

		private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(colorDialog1.ShowDialog()== DialogResult.OK )
			{
				pictureBox1.BackColor = colorDialog1.Color;
			}
		}
	}
}

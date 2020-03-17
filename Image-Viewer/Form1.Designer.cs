namespace Image_Viewer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.240949F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.33334F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(794, 415);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(178, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.changeBackgroundColorToolStripMenuItem,
            this.clearImageToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
			// 
			// openImageToolStripMenuItem
			// 
			this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
			this.openImageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.openImageToolStripMenuItem.Text = "Open Image";
			this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
			// 
			// changeBackgroundColorToolStripMenuItem
			// 
			this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
			this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
			this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
			// 
			// clearImageToolStripMenuItem
			// 
			this.clearImageToolStripMenuItem.Name = "clearImageToolStripMenuItem";
			this.clearImageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.clearImageToolStripMenuItem.Text = "Clear Image";
			this.clearImageToolStripMenuItem.Click += new System.EventHandler(this.clearImageToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// colorDialog1
			// 
			this.colorDialog1.Color = System.Drawing.Color.White;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Image File";
			this.openFileDialog1.Title = "Open Image";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Image Viewer";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}


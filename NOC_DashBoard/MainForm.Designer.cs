/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 26/02/2025
 * Time: 08:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_DashBoard
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.testToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.testToolStripMenuItem,
			this.testToolStripMenuItem3});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(44, 796);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.testToolStripMenuItem1,
			this.testToolStripMenuItem2});
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.testToolStripMenuItem.Text = "test";
			// 
			// testToolStripMenuItem1
			// 
			this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
			this.testToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.testToolStripMenuItem1.Text = "test";
			// 
			// testToolStripMenuItem2
			// 
			this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
			this.testToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.testToolStripMenuItem2.Text = "test";
			// 
			// testToolStripMenuItem3
			// 
			this.testToolStripMenuItem3.Name = "testToolStripMenuItem3";
			this.testToolStripMenuItem3.Size = new System.Drawing.Size(38, 20);
			this.testToolStripMenuItem3.Text = "test";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1397, 796);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "NOC_DashBoard";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

﻿namespace BrawlStageManager {
	partial class ThreeStageFrontStnameDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtMainStage = new System.Windows.Forms.TextBox();
			this.txtCombo1 = new System.Windows.Forms.TextBox();
			this.txtCombo1Stage = new System.Windows.Forms.TextBox();
			this.txtCombo2Stage = new System.Windows.Forms.TextBox();
			this.txtCombo2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.ContextMenuStrip = this.contextMenuStrip1;
			this.panel1.Location = new System.Drawing.Point(12, 151);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 168);
			this.panel1.TabIndex = 5;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// txtMainStage
			// 
			this.txtMainStage.AcceptsReturn = true;
			this.txtMainStage.Location = new System.Drawing.Point(12, 12);
			this.txtMainStage.Multiline = true;
			this.txtMainStage.Name = "txtMainStage";
			this.txtMainStage.Size = new System.Drawing.Size(208, 40);
			this.txtMainStage.TabIndex = 0;
			// 
			// txtCombo1
			// 
			this.txtCombo1.Location = new System.Drawing.Point(12, 69);
			this.txtCombo1.Name = "txtCombo1";
			this.txtCombo1.Size = new System.Drawing.Size(45, 20);
			this.txtCombo1.TabIndex = 1;
			// 
			// txtCombo1Stage
			// 
			this.txtCombo1Stage.AcceptsReturn = true;
			this.txtCombo1Stage.Location = new System.Drawing.Point(63, 59);
			this.txtCombo1Stage.Multiline = true;
			this.txtCombo1Stage.Name = "txtCombo1Stage";
			this.txtCombo1Stage.Size = new System.Drawing.Size(157, 40);
			this.txtCombo1Stage.TabIndex = 2;
			// 
			// txtCombo2Stage
			// 
			this.txtCombo2Stage.AcceptsReturn = true;
			this.txtCombo2Stage.Location = new System.Drawing.Point(63, 105);
			this.txtCombo2Stage.Multiline = true;
			this.txtCombo2Stage.Name = "txtCombo2Stage";
			this.txtCombo2Stage.Size = new System.Drawing.Size(157, 40);
			this.txtCombo2Stage.TabIndex = 4;
			// 
			// txtCombo2
			// 
			this.txtCombo2.Location = new System.Drawing.Point(12, 115);
			this.txtCombo2.Name = "txtCombo2";
			this.txtCombo2.Size = new System.Drawing.Size(45, 20);
			this.txtCombo2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(145, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(63, 325);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// ThreeStageFrontStnameDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(232, 360);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCombo2Stage);
			this.Controls.Add(this.txtCombo2);
			this.Controls.Add(this.txtCombo1Stage);
			this.Controls.Add(this.txtCombo1);
			this.Controls.Add(this.txtMainStage);
			this.Controls.Add(this.panel1);
			this.Name = "ThreeStageFrontStnameDialog";
			this.Text = "FrontStname";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMainStage;
		private System.Windows.Forms.TextBox txtCombo1;
		private System.Windows.Forms.TextBox txtCombo1Stage;
		private System.Windows.Forms.TextBox txtCombo2Stage;
		private System.Windows.Forms.TextBox txtCombo2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}


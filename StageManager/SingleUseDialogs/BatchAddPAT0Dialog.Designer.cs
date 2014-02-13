﻿namespace BrawlStageManager.SingleUseDialogs {
	partial class BatchAddPAT0Dialog {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.radioOneEach = new System.Windows.Forms.RadioButton();
			this.radioCopyFromPrevious = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.OK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblVSeparator = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Would you like to fill in the gaps on PAT0 entries in\r\nthe sc_selmap so there\'s o" +
    "ne for each stage?\r\n ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Prevbase, Icon,\r\nFrontStname:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 65);
			this.label3.TabIndex = 2;
			this.label3.Text = "All stages will point to their\r\nown texture number - e.g.\r\nMenSelmapIcon.35 - eve" +
    "n\r\nif the corresponding image\r\nis not in the sc_selmap yet.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(161, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "SelchrMark,\r\nSelmapMark:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(161, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 65);
			this.label5.TabIndex = 4;
			this.label5.Text = "These stage-to-texture mappings\r\ncan be edited with the \"Modify\r\nPAT0 Mapping\" bu" +
    "tton.\r\n\r\nInitial values:";
			// 
			// radioOneEach
			// 
			this.radioOneEach.AutoSize = true;
			this.radioOneEach.Location = new System.Drawing.Point(164, 142);
			this.radioOneEach.Name = "radioOneEach";
			this.radioOneEach.Size = new System.Drawing.Size(142, 30);
			this.radioOneEach.TabIndex = 5;
			this.radioOneEach.TabStop = true;
			this.radioOneEach.Text = "One for each stage\r\n(e.g. MenSelchrMark.32)";
			this.radioOneEach.UseVisualStyleBackColor = true;
			// 
			// radioCopyFromPrevious
			// 
			this.radioCopyFromPrevious.AutoSize = true;
			this.radioCopyFromPrevious.Location = new System.Drawing.Point(164, 178);
			this.radioCopyFromPrevious.Name = "radioCopyFromPrevious";
			this.radioCopyFromPrevious.Size = new System.Drawing.Size(141, 30);
			this.radioCopyFromPrevious.TabIndex = 6;
			this.radioCopyFromPrevious.TabStop = true;
			this.radioCopyFromPrevious.Text = "Use MenSelchrMark.20\r\nand MenSelmapMark.01";
			this.radioCopyFromPrevious.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 211);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "No new textures will be added to the file.";
			// 
			// OK
			// 
			this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK.Location = new System.Drawing.Point(247, 226);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 9;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(166, 226);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblVSeparator
			// 
			this.lblVSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblVSeparator.Location = new System.Drawing.Point(152, 47);
			this.lblVSeparator.Name = "lblVSeparator";
			this.lblVSeparator.Size = new System.Drawing.Size(3, 161);
			this.lblVSeparator.TabIndex = 10;
			this.lblVSeparator.Text = "label7";
			// 
			// BatchAddPAT0Dialog
			// 
			this.AcceptButton = this.OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(334, 261);
			this.Controls.Add(this.lblVSeparator);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.radioCopyFromPrevious);
			this.Controls.Add(this.radioOneEach);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "BatchAddPAT0Dialog";
			this.Text = "Prepare PAT0 Entries";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioOneEach;
		private System.Windows.Forms.RadioButton radioCopyFromPrevious;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblVSeparator;
	}
}
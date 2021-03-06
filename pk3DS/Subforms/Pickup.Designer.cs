﻿namespace pk3DS
{
    partial class Pickup
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
            if (disposing && (components != null))
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
            this.dgvCommon = new System.Windows.Forms.DataGridView();
            this.L_TM = new System.Windows.Forms.Label();
            this.dgvRare = new System.Windows.Forms.DataGridView();
            this.L_HM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRare)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommon
            // 
            this.dgvCommon.AllowUserToAddRows = false;
            this.dgvCommon.AllowUserToDeleteRows = false;
            this.dgvCommon.AllowUserToResizeColumns = false;
            this.dgvCommon.AllowUserToResizeRows = false;
            this.dgvCommon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommon.Location = new System.Drawing.Point(9, 25);
            this.dgvCommon.Name = "dgvCommon";
            this.dgvCommon.Size = new System.Drawing.Size(240, 300);
            this.dgvCommon.TabIndex = 1;
            // 
            // L_TM
            // 
            this.L_TM.AutoSize = true;
            this.L_TM.Location = new System.Drawing.Point(9, 9);
            this.L_TM.Name = "L_TM";
            this.L_TM.Size = new System.Drawing.Size(97, 13);
            this.L_TM.TabIndex = 2;
            this.L_TM.Text = "Common (30%-4%):";
            // 
            // dgvRare
            // 
            this.dgvRare.AllowUserToAddRows = false;
            this.dgvRare.AllowUserToDeleteRows = false;
            this.dgvRare.AllowUserToResizeColumns = false;
            this.dgvRare.AllowUserToResizeRows = false;
            this.dgvRare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRare.Location = new System.Drawing.Point(256, 25);
            this.dgvRare.Name = "dgvRare";
            this.dgvRare.Size = new System.Drawing.Size(240, 300);
            this.dgvRare.TabIndex = 3;
            // 
            // L_HM
            // 
            this.L_HM.AutoSize = true;
            this.L_HM.Location = new System.Drawing.Point(253, 9);
            this.L_HM.Name = "L_HM";
            this.L_HM.Size = new System.Drawing.Size(56, 13);
            this.L_HM.TabIndex = 4;
            this.L_HM.Text = "Rare (1%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(level-1)/10, take 9.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "(level-1)/10, take 2.";
            // 
            // Pickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_HM);
            this.Controls.Add(this.dgvRare);
            this.Controls.Add(this.L_TM);
            this.Controls.Add(this.dgvCommon);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 670);
            this.MinimumSize = new System.Drawing.Size(520, 370);
            this.Name = "Pickup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pickup Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommon;
        private System.Windows.Forms.Label L_TM;
        private System.Windows.Forms.DataGridView dgvRare;
        private System.Windows.Forms.Label L_HM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
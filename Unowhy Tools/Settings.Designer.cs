﻿
namespace Unowhy_Tools
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.langlab = new System.Windows.Forms.Label();
            this.langsel = new System.Windows.Forms.ComboBox();
            this.cbupdate = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.okbtn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // langlab
            // 
            this.langlab.AutoSize = true;
            this.langlab.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langlab.ForeColor = System.Drawing.Color.White;
            this.langlab.Location = new System.Drawing.Point(36, 13);
            this.langlab.Name = "langlab";
            this.langlab.Size = new System.Drawing.Size(64, 13);
            this.langlab.TabIndex = 0;
            this.langlab.Text = "Language :";
            // 
            // langsel
            // 
            this.langsel.BackColor = System.Drawing.Color.Black;
            this.langsel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langsel.ForeColor = System.Drawing.Color.White;
            this.langsel.FormattingEnabled = true;
            this.langsel.Items.AddRange(new object[] {
            "English",
            "French"});
            this.langsel.Location = new System.Drawing.Point(103, 10);
            this.langsel.Name = "langsel";
            this.langsel.Size = new System.Drawing.Size(121, 21);
            this.langsel.TabIndex = 2;
            this.langsel.SelectedIndexChanged += new System.EventHandler(this.langsel_SelectedIndexChanged);
            // 
            // cbupdate
            // 
            this.cbupdate.AutoSize = true;
            this.cbupdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbupdate.ForeColor = System.Drawing.Color.White;
            this.cbupdate.Location = new System.Drawing.Point(35, 45);
            this.cbupdate.Name = "cbupdate";
            this.cbupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbupdate.Size = new System.Drawing.Size(150, 17);
            this.cbupdate.TabIndex = 3;
            this.cbupdate.Text = "Check update at startup";
            this.cbupdate.UseVisualStyleBackColor = true;
            this.cbupdate.CheckedChanged += new System.EventHandler(this.cbupdate_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Unowhy_Tools.Properties.Resources.language;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Unowhy_Tools.Properties.Resources.update;
            this.pictureBox2.Location = new System.Drawing.Point(10, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Unowhy_Tools.Properties.Resources.startup;
            this.pictureBox3.Location = new System.Drawing.Point(15, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Unowhy_Tools.Properties.Resources.yes;
            this.pictureBox4.Location = new System.Drawing.Point(141, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // okbtn
            // 
            this.okbtn.BackColor = System.Drawing.Color.Transparent;
            this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.okbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okbtn.Image = null;
            this.okbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okbtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.okbtn.Location = new System.Drawing.Point(162, 72);
            this.okbtn.Name = "okbtn";
            this.okbtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.okbtn.Size = new System.Drawing.Size(72, 23);
            this.okbtn.TabIndex = 5;
            this.okbtn.Text = "OK";
            this.okbtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(238, 99);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbupdate);
            this.Controls.Add(this.langsel);
            this.Controls.Add(this.langlab);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label langlab;
        private System.Windows.Forms.ComboBox langsel;
        private System.Windows.Forms.CheckBox cbupdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ReaLTaiizor.Controls.Button okbtn;
    }
}
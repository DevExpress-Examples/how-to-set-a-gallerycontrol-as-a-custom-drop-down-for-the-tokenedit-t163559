﻿using DevExpress.XtraTreeList;
namespace TokenEditCustomDropDown {
    partial class Form1 {
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
            this.tokenEdit1 = new DevExpress.XtraEditors.TokenEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenEdit1
            // 
            this.tokenEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenEdit1.Location = new System.Drawing.Point(12, 28);
            this.tokenEdit1.Name = "tokenEdit1";
            this.tokenEdit1.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tokenEdit1.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEdit1.Size = new System.Drawing.Size(659, 20);
            this.tokenEdit1.TabIndex = 0;
            this.tokenEdit1.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tokenEdit1_ValidateToken);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 77);
            this.Controls.Add(this.tokenEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TokenEdit tokenEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}


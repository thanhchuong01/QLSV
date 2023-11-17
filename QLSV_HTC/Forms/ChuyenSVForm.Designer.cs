
namespace QLSV_HTC.Forms
{
    partial class ChuyenSVForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditCHUYENLOP = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCHUYENLOP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(109, 96);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(173, 27);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Chuyển lớp";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(337, 96);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(146, 27);
            this.btnDeny.TabIndex = 2;
            this.btnDeny.Text = "Thoát";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã lớp chuyển đến";
            // 
            // txtEditCHUYENLOP
            // 
            this.txtEditCHUYENLOP.Location = new System.Drawing.Point(95, 47);
            this.txtEditCHUYENLOP.Name = "txtEditCHUYENLOP";
            this.txtEditCHUYENLOP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditCHUYENLOP.Size = new System.Drawing.Size(410, 20);
            this.txtEditCHUYENLOP.TabIndex = 4;
            // 
            // ChuyenSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 164);
            this.Controls.Add(this.txtEditCHUYENLOP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnConfirm);
            this.Location = new System.Drawing.Point(361, 255);
            this.Name = "ChuyenSVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chuyển sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCHUYENLOP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtEditCHUYENLOP;
    }
}
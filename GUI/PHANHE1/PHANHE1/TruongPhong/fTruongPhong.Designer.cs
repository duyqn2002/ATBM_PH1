
namespace PHANHE1.TruongPhong
{
    partial class fTruongPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditPC = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditPC);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(92, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 524);
            this.panel1.TabIndex = 2;
            // 
            // btnEditPC
            // 
            this.btnEditPC.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEditPC.Location = new System.Drawing.Point(738, 91);
            this.btnEditPC.Name = "btnEditPC";
            this.btnEditPC.Size = new System.Drawing.Size(251, 378);
            this.btnEditPC.TabIndex = 3;
            this.btnEditPC.Text = "Edit on PHANCONG";
            this.btnEditPC.UseVisualStyleBackColor = false;
            this.btnEditPC.Click += new System.EventHandler(this.btnEditPC_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.PeachPuff;
            this.btnView.Location = new System.Drawing.Point(52, 91);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(251, 378);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View information";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEdit.Location = new System.Drawing.Point(407, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(251, 378);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit information";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogOut.Location = new System.Drawing.Point(25, 23);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(124, 50);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // fTruongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1216, 710);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "fTruongPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTruongPhong";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEditPC;
        private System.Windows.Forms.Button btnLogOut;
    }
}
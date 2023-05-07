
namespace PHANHE1.TruongDeAn
{
    partial class fEditDA
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbiDA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAttr = new System.Windows.Forms.ComboBox();
            this.tbuVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbuDA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Location = new System.Drawing.Point(26, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 592);
            this.panel1.TabIndex = 10;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabInsert);
            this.tabControl.Controls.Add(this.tabUpdate);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(3, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1147, 557);
            this.tabControl.TabIndex = 0;
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.SeaShell;
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.Controls.Add(this.tbiDA);
            this.tabInsert.Controls.Add(this.label1);
            this.tabInsert.Location = new System.Drawing.Point(4, 32);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(1139, 521);
            this.tabInsert.TabIndex = 0;
            this.tabInsert.Text = "Insert";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInsert.Location = new System.Drawing.Point(791, 228);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(147, 41);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbiDA
            // 
            this.tbiDA.Location = new System.Drawing.Point(402, 235);
            this.tbiDA.Name = "tbiDA";
            this.tbiDA.Size = new System.Drawing.Size(361, 26);
            this.tbiDA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert DEAN";
            // 
            // tabUpdate
            // 
            this.tabUpdate.BackColor = System.Drawing.Color.SeaShell;
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Controls.Add(this.label4);
            this.tabUpdate.Controls.Add(this.cbAttr);
            this.tabUpdate.Controls.Add(this.tbuVal);
            this.tabUpdate.Controls.Add(this.label3);
            this.tabUpdate.Controls.Add(this.tbuDA);
            this.tabUpdate.Controls.Add(this.label2);
            this.tabUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(1139, 521);
            this.tabUpdate.TabIndex = 1;
            this.tabUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(455, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALUE";
            // 
            // cbAttr
            // 
            this.cbAttr.FormattingEnabled = true;
            this.cbAttr.Location = new System.Drawing.Point(605, 208);
            this.cbAttr.Name = "cbAttr";
            this.cbAttr.Size = new System.Drawing.Size(153, 28);
            this.cbAttr.TabIndex = 4;
            // 
            // tbuVal
            // 
            this.tbuVal.Location = new System.Drawing.Point(885, 208);
            this.tbuVal.Name = "tbuVal";
            this.tbuVal.Size = new System.Drawing.Size(199, 26);
            this.tbuVal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ATTRIBUTE";
            // 
            // tbuDA
            // 
            this.tbuDA.Location = new System.Drawing.Point(218, 208);
            this.tbuDA.Name = "tbuDA";
            this.tbuDA.Size = new System.Drawing.Size(199, 26);
            this.tbuDA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update DEAN";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.tbDel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1139, 521);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDel.Location = new System.Drawing.Point(794, 237);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(147, 41);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbDel
            // 
            this.tbDel.Location = new System.Drawing.Point(405, 244);
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(361, 26);
            this.tbDel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Delete DEAN";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBack.Location = new System.Drawing.Point(26, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 42);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fEditDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1216, 710);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "fEditDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditDA";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbiDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAttr;
        private System.Windows.Forms.TextBox tbuVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbuDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbDel;
        private System.Windows.Forms.Label label5;
    }
}
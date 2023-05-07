
namespace PHANHE1.TruongPhong
{
    partial class fTP_EditPC
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
            this.tbiDA = new System.Windows.Forms.TextBox();
            this.DEAN = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbiNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.tbDA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAttr = new System.Windows.Forms.ComboBox();
            this.tbuVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbuNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.tbdDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbdNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Location = new System.Drawing.Point(26, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 603);
            this.panel1.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabInsert);
            this.tabControl.Controls.Add(this.tabUpdate);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(3, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1147, 556);
            this.tabControl.TabIndex = 0;
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.SeaShell;
            this.tabInsert.Controls.Add(this.tbiDA);
            this.tabInsert.Controls.Add(this.DEAN);
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.Controls.Add(this.tbiNV);
            this.tabInsert.Controls.Add(this.label1);
            this.tabInsert.Location = new System.Drawing.Point(4, 32);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(1139, 520);
            this.tabInsert.TabIndex = 0;
            this.tabInsert.Text = "Insert";
            // 
            // tbiDA
            // 
            this.tbiDA.Location = new System.Drawing.Point(607, 236);
            this.tbiDA.Name = "tbiDA";
            this.tbiDA.Size = new System.Drawing.Size(202, 26);
            this.tbiDA.TabIndex = 4;
            // 
            // DEAN
            // 
            this.DEAN.AutoSize = true;
            this.DEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEAN.Location = new System.Drawing.Point(509, 236);
            this.DEAN.Name = "DEAN";
            this.DEAN.Size = new System.Drawing.Size(79, 29);
            this.DEAN.TabIndex = 3;
            this.DEAN.Text = "DEAN";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInsert.Location = new System.Drawing.Point(830, 229);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(147, 41);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbiNV
            // 
            this.tbiNV.Location = new System.Drawing.Point(326, 236);
            this.tbiNV.Name = "tbiNV";
            this.tbiNV.Size = new System.Drawing.Size(167, 26);
            this.tbiNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert NHANVIEN";
            // 
            // tabUpdate
            // 
            this.tabUpdate.BackColor = System.Drawing.Color.SeaShell;
            this.tabUpdate.Controls.Add(this.tbDA);
            this.tabUpdate.Controls.Add(this.label7);
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Controls.Add(this.label4);
            this.tabUpdate.Controls.Add(this.cbAttr);
            this.tabUpdate.Controls.Add(this.tbuVal);
            this.tabUpdate.Controls.Add(this.label3);
            this.tabUpdate.Controls.Add(this.tbuNV);
            this.tabUpdate.Controls.Add(this.label2);
            this.tabUpdate.Location = new System.Drawing.Point(4, 33);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(1139, 519);
            this.tabUpdate.TabIndex = 1;
            this.tabUpdate.Text = "Update";
            // 
            // tbDA
            // 
            this.tbDA.Location = new System.Drawing.Point(454, 206);
            this.tbDA.Name = "tbDA";
            this.tbDA.Size = new System.Drawing.Size(120, 26);
            this.tbDA.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "DEAN";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(483, 304);
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
            this.label4.Location = new System.Drawing.Point(817, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALUE";
            // 
            // cbAttr
            // 
            this.cbAttr.FormattingEnabled = true;
            this.cbAttr.Location = new System.Drawing.Point(661, 206);
            this.cbAttr.Name = "cbAttr";
            this.cbAttr.Size = new System.Drawing.Size(136, 28);
            this.cbAttr.TabIndex = 4;
            // 
            // tbuVal
            // 
            this.tbuVal.Location = new System.Drawing.Point(936, 208);
            this.tbuVal.Name = "tbuVal";
            this.tbuVal.Size = new System.Drawing.Size(136, 26);
            this.tbuVal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ON";
            // 
            // tbuNV
            // 
            this.tbuNV.Location = new System.Drawing.Point(232, 205);
            this.tbuNV.Name = "tbuNV";
            this.tbuNV.Size = new System.Drawing.Size(120, 26);
            this.tbuNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update NHANVIEN";
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.SeaShell;
            this.tabDelete.Controls.Add(this.tbdDA);
            this.tabDelete.Controls.Add(this.label6);
            this.tabDelete.Controls.Add(this.btnDel);
            this.tabDelete.Controls.Add(this.tbdNV);
            this.tabDelete.Controls.Add(this.label5);
            this.tabDelete.Location = new System.Drawing.Point(4, 33);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(1139, 519);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            // 
            // tbdDA
            // 
            this.tbdDA.Location = new System.Drawing.Point(587, 201);
            this.tbdDA.Name = "tbdDA";
            this.tbdDA.Size = new System.Drawing.Size(222, 26);
            this.tbdDA.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "DEAN";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(849, 184);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(152, 68);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbdNV
            // 
            this.tbdNV.Location = new System.Drawing.Point(280, 201);
            this.tbdNV.Name = "tbdNV";
            this.tbdNV.Size = new System.Drawing.Size(188, 26);
            this.tbdNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Delete NHANVIEN";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBack.Location = new System.Drawing.Point(26, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 42);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fTP_EditPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1216, 710);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "fTP_EditPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTP_EditPC";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbiNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbuNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAttr;
        private System.Windows.Forms.TextBox tbuVal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbdNV;
        private System.Windows.Forms.Label DEAN;
        private System.Windows.Forms.TextBox tbiDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbdDA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDA;
    }
}
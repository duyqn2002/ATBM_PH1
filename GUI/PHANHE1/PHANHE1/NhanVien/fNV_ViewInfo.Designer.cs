﻿
namespace PHANHE1.NhanVien
{
    partial class fNV_ViewInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBack.Location = new System.Drawing.Point(26, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.dgvShow);
            this.panel1.Controls.Add(this.Category);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(57, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 580);
            this.panel1.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.PeachPuff;
            this.btnView.Location = new System.Drawing.Point(760, 23);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 48);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View ";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShow.Location = new System.Drawing.Point(47, 106);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 62;
            this.dgvShow.RowTemplate.Height = 28;
            this.dgvShow.Size = new System.Drawing.Size(1012, 446);
            this.dgvShow.TabIndex = 2;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(233, 34);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(195, 29);
            this.Category.TabIndex = 1;
            this.Category.Text = "Choose category";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // fNV_ViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1216, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.MaximumSize = new System.Drawing.Size(1238, 766);
            this.Name = "fNV_ViewInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNV_ViewInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnView;
    }
}
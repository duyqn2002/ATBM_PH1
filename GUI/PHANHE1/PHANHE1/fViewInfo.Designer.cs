
namespace PHANHE1
{
    partial class fViewInfo
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCatg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.Location = new System.Drawing.Point(26, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvView);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboCatg);
            this.panel1.Location = new System.Drawing.Point(71, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 584);
            this.panel1.TabIndex = 4;
            // 
            // cboCatg
            // 
            this.cboCatg.FormattingEnabled = true;
            this.cboCatg.Location = new System.Drawing.Point(446, 35);
            this.cboCatg.Name = "cboCatg";
            this.cboCatg.Size = new System.Drawing.Size(211, 28);
            this.cboCatg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "View category";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.BurlyWood;
            this.btnView.Location = new System.Drawing.Point(717, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(123, 52);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(33, 98);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidth = 62;
            this.dgvView.RowTemplate.Height = 28;
            this.dgvView.Size = new System.Drawing.Size(1023, 464);
            this.dgvView.TabIndex = 6;
            // 
            // fViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1216, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "fViewInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fViewInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCatg;
        private System.Windows.Forms.DataGridView dgvView;
    }
}
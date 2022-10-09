namespace EF_vs_3_others
{
    partial class Form1
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
            this.btn_adHoc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_para = new System.Windows.Forms.Button();
            this.btn_stored = new System.Windows.Forms.Button();
            this.btn_ef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adHoc
            // 
            this.btn_adHoc.Location = new System.Drawing.Point(12, 56);
            this.btn_adHoc.Name = "btn_adHoc";
            this.btn_adHoc.Size = new System.Drawing.Size(139, 28);
            this.btn_adHoc.TabIndex = 0;
            this.btn_adHoc.Text = "Ad-Hoc";
            this.btn_adHoc.UseVisualStyleBackColor = true;
            this.btn_adHoc.Click += new System.EventHandler(this.btn_adHoc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 219);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID:";
            // 
            // btn_para
            // 
            this.btn_para.Location = new System.Drawing.Point(12, 105);
            this.btn_para.Name = "btn_para";
            this.btn_para.Size = new System.Drawing.Size(139, 28);
            this.btn_para.TabIndex = 4;
            this.btn_para.Text = "Use Parameter";
            this.btn_para.UseVisualStyleBackColor = true;
            this.btn_para.Click += new System.EventHandler(this.btn_para_Click);
            // 
            // btn_stored
            // 
            this.btn_stored.Location = new System.Drawing.Point(12, 154);
            this.btn_stored.Name = "btn_stored";
            this.btn_stored.Size = new System.Drawing.Size(139, 28);
            this.btn_stored.TabIndex = 5;
            this.btn_stored.Text = "Stored Procedure";
            this.btn_stored.UseVisualStyleBackColor = true;
            this.btn_stored.Click += new System.EventHandler(this.btn_stored_Click);
            // 
            // btn_ef
            // 
            this.btn_ef.Location = new System.Drawing.Point(12, 204);
            this.btn_ef.Name = "btn_ef";
            this.btn_ef.Size = new System.Drawing.Size(139, 28);
            this.btn_ef.TabIndex = 6;
            this.btn_ef.Text = "Entity Framework";
            this.btn_ef.UseVisualStyleBackColor = true;
            this.btn_ef.Click += new System.EventHandler(this.btn_ef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.Controls.Add(this.btn_ef);
            this.Controls.Add(this.btn_stored);
            this.Controls.Add(this.btn_para);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_adHoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_para;
        private System.Windows.Forms.Button btn_stored;
        private System.Windows.Forms.Button btn_ef;
    }
}


namespace ExelToForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.PictureBox();
            this.pdf_export = new System.Windows.Forms.PictureBox();
            this.printIfno = new System.Windows.Forms.Label();
            this.assistant_combo = new System.Windows.Forms.ComboBox();
            this.aslabelr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_export)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "აირჩიეთ ექსელი";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(600, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "აირჩიეთ ვორდის დოკუმენტი";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // print_btn
            // 
            this.print_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.print_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.Location = new System.Drawing.Point(666, 345);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(49, 50);
            this.print_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.print_btn.TabIndex = 3;
            this.print_btn.TabStop = false;
            this.print_btn.Visible = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // pdf_export
            // 
            this.pdf_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdf_export.Image = ((System.Drawing.Image)(resources.GetObject("pdf_export.Image")));
            this.pdf_export.Location = new System.Drawing.Point(730, 345);
            this.pdf_export.Name = "pdf_export";
            this.pdf_export.Size = new System.Drawing.Size(57, 50);
            this.pdf_export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pdf_export.TabIndex = 4;
            this.pdf_export.TabStop = false;
            this.pdf_export.Visible = false;
            this.pdf_export.Click += new System.EventHandler(this.pdf_export_Click);
            // 
            // printIfno
            // 
            this.printIfno.Location = new System.Drawing.Point(507, 299);
            this.printIfno.Name = "printIfno";
            this.printIfno.Size = new System.Drawing.Size(280, 23);
            this.printIfno.TabIndex = 7;
            this.printIfno.Text = "label2";
            // 
            // assistant_combo
            // 
            this.assistant_combo.FormattingEnabled = true;
            this.assistant_combo.Location = new System.Drawing.Point(13, 245);
            this.assistant_combo.Name = "assistant_combo";
            this.assistant_combo.Size = new System.Drawing.Size(200, 21);
            this.assistant_combo.TabIndex = 8;
            this.assistant_combo.SelectedIndexChanged += new System.EventHandler(this.assistant_combo_SelectedIndexChanged);
            // 
            // aslabelr
            // 
            this.aslabelr.AutoSize = true;
            this.aslabelr.Location = new System.Drawing.Point(13, 226);
            this.aslabelr.Name = "aslabelr";
            this.aslabelr.Size = new System.Drawing.Size(65, 13);
            this.aslabelr.TabIndex = 9;
            this.aslabelr.Text = "თანაშემწე";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aslabelr);
            this.Controls.Add(this.assistant_combo);
            this.Controls.Add(this.printIfno);
            this.Controls.Add(this.pdf_export);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_export)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox print_btn;
        private System.Windows.Forms.PictureBox pdf_export;
        private System.Windows.Forms.Label printIfno;
        private System.Windows.Forms.ComboBox assistant_combo;
        private System.Windows.Forms.Label aslabelr;
    }
}


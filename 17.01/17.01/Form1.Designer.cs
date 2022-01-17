namespace _17._01
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Cislo1 = new System.Windows.Forms.TextBox();
            this.Zadani = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadej cislo";
            // 
            // Cislo1
            // 
            this.Cislo1.Location = new System.Drawing.Point(76, 26);
            this.Cislo1.Name = "Cislo1";
            this.Cislo1.Size = new System.Drawing.Size(100, 20);
            this.Cislo1.TabIndex = 1;
            this.Cislo1.TextChanged += new System.EventHandler(this.Cislo1_TextChanged);
            // 
            // Zadani
            // 
            this.Zadani.BackColor = System.Drawing.SystemColors.Control;
            this.Zadani.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Zadani.Location = new System.Drawing.Point(194, 26);
            this.Zadani.Name = "Zadani";
            this.Zadani.Size = new System.Drawing.Size(75, 23);
            this.Zadani.TabIndex = 2;
            this.Zadani.Text = "Vypocet";
            this.Zadani.UseVisualStyleBackColor = false;
            this.Zadani.Click += new System.EventHandler(this.Zadani_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 108);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(283, 176);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Zadani);
            this.Controls.Add(this.Cislo1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nabidka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cislo1;
        private System.Windows.Forms.Button Zadani;
        private System.Windows.Forms.ListBox listBox1;
    }
}


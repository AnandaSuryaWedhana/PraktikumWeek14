
namespace Praktikum14
{
    partial class Praktikum
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
            this.mintainputan = new System.Windows.Forms.Label();
            this.Masukkan = new System.Windows.Forms.TextBox();
            this.reversebutton = new System.Windows.Forms.Button();
            this.Urutkan = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mintainputan
            // 
            this.mintainputan.AutoSize = true;
            this.mintainputan.Location = new System.Drawing.Point(51, 55);
            this.mintainputan.Name = "mintainputan";
            this.mintainputan.Size = new System.Drawing.Size(58, 20);
            this.mintainputan.TabIndex = 0;
            this.mintainputan.Text = "Input : ";
            // 
            // Masukkan
            // 
            this.Masukkan.Location = new System.Drawing.Point(55, 88);
            this.Masukkan.Name = "Masukkan";
            this.Masukkan.Size = new System.Drawing.Size(357, 26);
            this.Masukkan.TabIndex = 1;
            // 
            // reversebutton
            // 
            this.reversebutton.Location = new System.Drawing.Point(55, 144);
            this.reversebutton.Name = "reversebutton";
            this.reversebutton.Size = new System.Drawing.Size(150, 44);
            this.reversebutton.TabIndex = 2;
            this.reversebutton.Text = "Reverse";
            this.reversebutton.UseVisualStyleBackColor = true;
            this.reversebutton.Click += new System.EventHandler(this.reversebutton_Click);
            // 
            // Urutkan
            // 
            this.Urutkan.Location = new System.Drawing.Point(223, 144);
            this.Urutkan.Name = "Urutkan";
            this.Urutkan.Size = new System.Drawing.Size(189, 44);
            this.Urutkan.TabIndex = 3;
            this.Urutkan.Text = "Urutkan";
            this.Urutkan.UseVisualStyleBackColor = true;
            this.Urutkan.Click += new System.EventHandler(this.Urutkan_Click);
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(55, 228);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(58, 20);
            this.hasil.TabIndex = 4;
            this.hasil.Text = "Output";
            this.hasil.Click += new System.EventHandler(this.label2_Click);
            // 
            // Praktikum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.Urutkan);
            this.Controls.Add(this.reversebutton);
            this.Controls.Add(this.Masukkan);
            this.Controls.Add(this.mintainputan);
            this.Name = "Praktikum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mintainputan;
        private System.Windows.Forms.TextBox Masukkan;
        private System.Windows.Forms.Button reversebutton;
        private System.Windows.Forms.Button Urutkan;
        private System.Windows.Forms.Label hasil;
    }
}


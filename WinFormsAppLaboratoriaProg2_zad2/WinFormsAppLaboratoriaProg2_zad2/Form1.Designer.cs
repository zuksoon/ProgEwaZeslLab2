
namespace WinFormsAppLaboratoriaProg2_zad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCzerwony = new System.Windows.Forms.RadioButton();
            this.rdoZielony = new System.Windows.Forms.RadioButton();
            this.rdoNiebieski = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNiebieski);
            this.groupBox1.Controls.Add(this.rdoZielony);
            this.groupBox1.Controls.Add(this.rdoCzerwony);
            this.groupBox1.Location = new System.Drawing.Point(117, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz swój ulubiony kolor";
            // 
            // rdoCzerwony
            // 
            this.rdoCzerwony.AutoSize = true;
            this.rdoCzerwony.Location = new System.Drawing.Point(21, 35);
            this.rdoCzerwony.Name = "rdoCzerwony";
            this.rdoCzerwony.Size = new System.Drawing.Size(77, 19);
            this.rdoCzerwony.TabIndex = 0;
            this.rdoCzerwony.TabStop = true;
            this.rdoCzerwony.Text = "Czerwony";
            this.rdoCzerwony.UseVisualStyleBackColor = true;
            // 
            // rdoZielony
            // 
            this.rdoZielony.AutoSize = true;
            this.rdoZielony.Location = new System.Drawing.Point(21, 76);
            this.rdoZielony.Name = "rdoZielony";
            this.rdoZielony.Size = new System.Drawing.Size(64, 19);
            this.rdoZielony.TabIndex = 1;
            this.rdoZielony.TabStop = true;
            this.rdoZielony.Text = "Zielony";
            this.rdoZielony.UseVisualStyleBackColor = true;
            // 
            // rdoNiebieski
            // 
            this.rdoNiebieski.AutoSize = true;
            this.rdoNiebieski.Location = new System.Drawing.Point(21, 121);
            this.rdoNiebieski.Name = "rdoNiebieski";
            this.rdoNiebieski.Size = new System.Drawing.Size(73, 19);
            this.rdoNiebieski.TabIndex = 2;
            this.rdoNiebieski.TabStop = true;
            this.rdoNiebieski.Text = "Niebieski";
            this.rdoNiebieski.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNiebieski;
        private System.Windows.Forms.RadioButton rdoZielony;
        private System.Windows.Forms.RadioButton rdoCzerwony;
        private System.Windows.Forms.Button button1;
    }
}


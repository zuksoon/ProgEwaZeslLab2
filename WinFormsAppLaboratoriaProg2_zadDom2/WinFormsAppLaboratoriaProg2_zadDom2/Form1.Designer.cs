
namespace WinFormsAppLaboratoriaProg2_zadDom2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBardzoDuza = new System.Windows.Forms.RadioButton();
            this.rbtnDuza = new System.Windows.Forms.RadioButton();
            this.rbtnMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPodkreslenie = new System.Windows.Forms.CheckBox();
            this.checkBoxPochylenie = new System.Windows.Forms.CheckBox();
            this.checkBoxPogrubienie = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnPomaranczowy = new System.Windows.Forms.RadioButton();
            this.rbtnNiebieski = new System.Windows.Forms.RadioButton();
            this.rbtnCzerwony = new System.Windows.Forms.RadioButton();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 23);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBardzoDuza);
            this.groupBox1.Controls.Add(this.rbtnDuza);
            this.groupBox1.Controls.Add(this.rbtnMala);
            this.groupBox1.Location = new System.Drawing.Point(131, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // rbtnBardzoDuza
            // 
            this.rbtnBardzoDuza.AutoSize = true;
            this.rbtnBardzoDuza.Location = new System.Drawing.Point(7, 120);
            this.rbtnBardzoDuza.Name = "rbtnBardzoDuza";
            this.rbtnBardzoDuza.Size = new System.Drawing.Size(89, 19);
            this.rbtnBardzoDuza.TabIndex = 2;
            this.rbtnBardzoDuza.TabStop = true;
            this.rbtnBardzoDuza.Text = "bardzo duża";
            this.rbtnBardzoDuza.UseVisualStyleBackColor = true;
            // 
            // rbtnDuza
            // 
            this.rbtnDuza.AutoSize = true;
            this.rbtnDuza.Location = new System.Drawing.Point(7, 77);
            this.rbtnDuza.Name = "rbtnDuza";
            this.rbtnDuza.Size = new System.Drawing.Size(50, 19);
            this.rbtnDuza.TabIndex = 1;
            this.rbtnDuza.TabStop = true;
            this.rbtnDuza.Text = "duza";
            this.rbtnDuza.UseVisualStyleBackColor = true;
            // 
            // rbtnMala
            // 
            this.rbtnMala.AutoSize = true;
            this.rbtnMala.Checked = true;
            this.rbtnMala.Location = new System.Drawing.Point(7, 33);
            this.rbtnMala.Name = "rbtnMala";
            this.rbtnMala.Size = new System.Drawing.Size(51, 19);
            this.rbtnMala.TabIndex = 0;
            this.rbtnMala.TabStop = true;
            this.rbtnMala.Text = "mala";
            this.rbtnMala.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPodkreslenie);
            this.groupBox2.Controls.Add(this.checkBoxPochylenie);
            this.groupBox2.Controls.Add(this.checkBoxPogrubienie);
            this.groupBox2.Location = new System.Drawing.Point(339, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // checkBoxPodkreslenie
            // 
            this.checkBoxPodkreslenie.AutoSize = true;
            this.checkBoxPodkreslenie.Location = new System.Drawing.Point(20, 121);
            this.checkBoxPodkreslenie.Name = "checkBoxPodkreslenie";
            this.checkBoxPodkreslenie.Size = new System.Drawing.Size(93, 19);
            this.checkBoxPodkreslenie.TabIndex = 2;
            this.checkBoxPodkreslenie.Text = "Podkreślenie";
            this.checkBoxPodkreslenie.UseVisualStyleBackColor = true;
            // 
            // checkBoxPochylenie
            // 
            this.checkBoxPochylenie.AutoSize = true;
            this.checkBoxPochylenie.Location = new System.Drawing.Point(20, 78);
            this.checkBoxPochylenie.Name = "checkBoxPochylenie";
            this.checkBoxPochylenie.Size = new System.Drawing.Size(84, 19);
            this.checkBoxPochylenie.TabIndex = 1;
            this.checkBoxPochylenie.Text = "Pochylenie";
            this.checkBoxPochylenie.UseVisualStyleBackColor = true;
            // 
            // checkBoxPogrubienie
            // 
            this.checkBoxPogrubienie.AutoSize = true;
            this.checkBoxPogrubienie.Location = new System.Drawing.Point(20, 34);
            this.checkBoxPogrubienie.Name = "checkBoxPogrubienie";
            this.checkBoxPogrubienie.Size = new System.Drawing.Size(90, 19);
            this.checkBoxPogrubienie.TabIndex = 0;
            this.checkBoxPogrubienie.Text = "Pogrubienie";
            this.checkBoxPogrubienie.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnPomaranczowy);
            this.groupBox3.Controls.Add(this.rbtnNiebieski);
            this.groupBox3.Controls.Add(this.rbtnCzerwony);
            this.groupBox3.Location = new System.Drawing.Point(545, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // rbtnPomaranczowy
            // 
            this.rbtnPomaranczowy.AutoSize = true;
            this.rbtnPomaranczowy.Location = new System.Drawing.Point(7, 120);
            this.rbtnPomaranczowy.Name = "rbtnPomaranczowy";
            this.rbtnPomaranczowy.Size = new System.Drawing.Size(106, 19);
            this.rbtnPomaranczowy.TabIndex = 2;
            this.rbtnPomaranczowy.TabStop = true;
            this.rbtnPomaranczowy.Text = "pomarańczowy";
            this.rbtnPomaranczowy.UseVisualStyleBackColor = true;
            // 
            // rbtnNiebieski
            // 
            this.rbtnNiebieski.AutoSize = true;
            this.rbtnNiebieski.Location = new System.Drawing.Point(7, 77);
            this.rbtnNiebieski.Name = "rbtnNiebieski";
            this.rbtnNiebieski.Size = new System.Drawing.Size(71, 19);
            this.rbtnNiebieski.TabIndex = 1;
            this.rbtnNiebieski.Text = "niebieski";
            this.rbtnNiebieski.UseVisualStyleBackColor = true;
            // 
            // rbtnCzerwony
            // 
            this.rbtnCzerwony.AutoSize = true;
            this.rbtnCzerwony.Location = new System.Drawing.Point(7, 33);
            this.rbtnCzerwony.Name = "rbtnCzerwony";
            this.rbtnCzerwony.Size = new System.Drawing.Size(75, 19);
            this.rbtnCzerwony.TabIndex = 0;
            this.rbtnCzerwony.TabStop = true;
            this.rbtnCzerwony.Text = "czerwony";
            this.rbtnCzerwony.UseVisualStyleBackColor = true;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAktualizuj.Location = new System.Drawing.Point(339, 362);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(141, 44);
            this.btnAktualizuj.TabIndex = 5;
            this.btnAktualizuj.Text = "Aktualizuj";
            this.btnAktualizuj.UseVisualStyleBackColor = true;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPogrubienie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxPodkreslenie;
        private System.Windows.Forms.CheckBox checkBoxPochylenie;
        private System.Windows.Forms.RadioButton rbtnBardzoDuza;
        private System.Windows.Forms.RadioButton rbtnDuza;
        private System.Windows.Forms.RadioButton rbtnMala;
        private System.Windows.Forms.RadioButton rbtnPomaranczowy;
        private System.Windows.Forms.RadioButton rbtnNiebieski;
        private System.Windows.Forms.RadioButton rbtnCzerwony;
        private System.Windows.Forms.Button btnAktualizuj;
    }
}


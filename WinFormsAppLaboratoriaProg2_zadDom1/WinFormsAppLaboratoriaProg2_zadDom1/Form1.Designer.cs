
namespace WinFormsAppLaboratoriaProg2_zadDom1
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
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIdealna = new System.Windows.Forms.CheckBox();
            this.checkBoxStandardowa = new System.Windows.Forms.CheckBox();
            this.rbtnKobieta = new System.Windows.Forms.RadioButton();
            this.rbtnMezczyzna = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOblicz.Location = new System.Drawing.Point(339, 240);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 29);
            this.btnOblicz.TabIndex = 0;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj wzrost [cm]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj płeć";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIdealna);
            this.groupBox1.Controls.Add(this.checkBoxStandardowa);
            this.groupBox1.Location = new System.Drawing.Point(640, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waga";
            // 
            // checkBoxIdealna
            // 
            this.checkBoxIdealna.AutoSize = true;
            this.checkBoxIdealna.Location = new System.Drawing.Point(7, 56);
            this.checkBoxIdealna.Name = "checkBoxIdealna";
            this.checkBoxIdealna.Size = new System.Drawing.Size(64, 19);
            this.checkBoxIdealna.TabIndex = 1;
            this.checkBoxIdealna.Text = "Idealna";
            this.checkBoxIdealna.UseVisualStyleBackColor = true;
            this.checkBoxIdealna.CheckedChanged += new System.EventHandler(this.checkBoxIdealna_CheckedChanged);
            // 
            // checkBoxStandardowa
            // 
            this.checkBoxStandardowa.AutoSize = true;
            this.checkBoxStandardowa.Checked = true;
            this.checkBoxStandardowa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStandardowa.Location = new System.Drawing.Point(7, 23);
            this.checkBoxStandardowa.Name = "checkBoxStandardowa";
            this.checkBoxStandardowa.Size = new System.Drawing.Size(95, 19);
            this.checkBoxStandardowa.TabIndex = 0;
            this.checkBoxStandardowa.Text = "Standardowa";
            this.checkBoxStandardowa.UseVisualStyleBackColor = true;
            // 
            // rbtnKobieta
            // 
            this.rbtnKobieta.AutoSize = true;
            this.rbtnKobieta.Checked = true;
            this.rbtnKobieta.Location = new System.Drawing.Point(310, 136);
            this.rbtnKobieta.Name = "rbtnKobieta";
            this.rbtnKobieta.Size = new System.Drawing.Size(65, 19);
            this.rbtnKobieta.TabIndex = 4;
            this.rbtnKobieta.TabStop = true;
            this.rbtnKobieta.Text = "Kobieta";
            this.rbtnKobieta.UseVisualStyleBackColor = true;
            // 
            // rbtnMezczyzna
            // 
            this.rbtnMezczyzna.AutoSize = true;
            this.rbtnMezczyzna.Location = new System.Drawing.Point(430, 136);
            this.rbtnMezczyzna.Name = "rbtnMezczyzna";
            this.rbtnMezczyzna.Size = new System.Drawing.Size(82, 19);
            this.rbtnMezczyzna.TabIndex = 5;
            this.rbtnMezczyzna.Text = "Mężczyzna";
            this.rbtnMezczyzna.UseVisualStyleBackColor = true;
            this.rbtnMezczyzna.CheckedChanged += new System.EventHandler(this.rbtnMezczyzna_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wynik:";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWynik.Location = new System.Drawing.Point(114, 391);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(16, 21);
            this.labelWynik.TabIndex = 8;
            this.labelWynik.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnMezczyzna);
            this.Controls.Add(this.rbtnKobieta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOblicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxIdealna;
        private System.Windows.Forms.CheckBox checkBoxStandardowa;
        private System.Windows.Forms.RadioButton rbtnKobieta;
        private System.Windows.Forms.RadioButton rbtnMezczyzna;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWynik;
    }
}



namespace GemeinsamerTeiler
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
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.radioButton_kt = new System.Windows.Forms.RadioButton();
            this.radioButton_ggt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Berechne = new System.Windows.Forms.Button();
            this.textBox_Ergebniss = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ergebniss:";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(12, 12);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(295, 23);
            this.textBox_a.TabIndex = 1;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_Text_Changed);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(12, 42);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(295, 23);
            this.textBox_b.TabIndex = 3;
            this.textBox_b.TextChanged += new System.EventHandler(this.textBox_Text_Changed);
            // 
            // radioButton_kt
            // 
            this.radioButton_kt.AutoSize = true;
            this.radioButton_kt.Location = new System.Drawing.Point(58, 22);
            this.radioButton_kt.Name = "radioButton_kt";
            this.radioButton_kt.Size = new System.Drawing.Size(38, 19);
            this.radioButton_kt.TabIndex = 4;
            this.radioButton_kt.Text = "KT";
            this.radioButton_kt.UseVisualStyleBackColor = true;
            // 
            // radioButton_ggt
            // 
            this.radioButton_ggt.AutoSize = true;
            this.radioButton_ggt.Location = new System.Drawing.Point(6, 22);
            this.radioButton_ggt.Name = "radioButton_ggt";
            this.radioButton_ggt.Size = new System.Drawing.Size(46, 19);
            this.radioButton_ggt.TabIndex = 5;
            this.radioButton_ggt.Text = "GgT";
            this.radioButton_ggt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ggt);
            this.groupBox1.Controls.Add(this.radioButton_kt);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modus";
            // 
            // button_Berechne
            // 
            this.button_Berechne.Location = new System.Drawing.Point(218, 89);
            this.button_Berechne.Name = "button_Berechne";
            this.button_Berechne.Size = new System.Drawing.Size(75, 23);
            this.button_Berechne.TabIndex = 7;
            this.button_Berechne.Text = "Berechne";
            this.button_Berechne.UseVisualStyleBackColor = true;
            this.button_Berechne.Click += new System.EventHandler(this.button_Berechne_Click);
            // 
            // textBox_Ergebniss
            // 
            this.textBox_Ergebniss.Location = new System.Drawing.Point(93, 133);
            this.textBox_Ergebniss.Name = "textBox_Ergebniss";
            this.textBox_Ergebniss.ReadOnly = true;
            this.textBox_Ergebniss.Size = new System.Drawing.Size(100, 23);
            this.textBox_Ergebniss.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 168);
            this.Controls.Add(this.textBox_Ergebniss);
            this.Controls.Add(this.button_Berechne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Teiler berechnen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.RadioButton radioButton_ggt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Berechne;
        private System.Windows.Forms.RadioButton radioButton_kt;
        private System.Windows.Forms.TextBox textBox_Ergebniss;
    }
}


using System;
using System.Windows.Forms;
using MyMath;
namespace GemeinsamerTeiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton_ggt.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton_kt.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            evaluiereParameter();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            evaluiereParameter();
        }

        private void button_Berechne_Click(object sender, EventArgs e)
        {
            if (radioButton_ggt.Checked)
            {
                textBox_Ergebniss.Text = Teiler.ggt(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_b.Text)).ToString();
            }
            else textBox_Ergebniss.Text = Teiler.kgt(ulong.Parse(textBox_a.Text)).ToString();

        }


        private void textBox_Text_Changed(object sender, EventArgs e)
        {
            evaluiereParameter();
        }
        
        public void evaluiereParameter()
        {
            if (radioButton_kt.Checked)
            {
                textBox_a.Enabled = true;
                textBox_b.Enabled = false;
            }
            else if (radioButton_ggt.Checked)
            {
                textBox_a.Enabled = true;
                textBox_b.Enabled = true;
            }
            else
            {
                textBox_a.Enabled = false;
                textBox_b.Enabled = false;
            }
            if ((!textBox_a.Enabled || ulong.TryParse(textBox_a.Text, out _)) && (!textBox_b.Enabled || ulong.TryParse(textBox_b.Text, out _)) && (textBox_a.Enabled || textBox_b.Enabled))
            {
                button_Berechne.Enabled = true;
            }
            else button_Berechne.Enabled = false;
        }
    }
}

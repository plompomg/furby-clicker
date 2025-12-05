using System;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        private int _clickcount;
        public Form1()
        {
            InitializeComponent();

            //if there already is a number lemme check
            if (clicker_text != null)
            {
                int.TryParse(clicker_text.Text, out _clickcount);
                UpdateDisplay();
            }
        }

        private void IncrementClick()
        {
            _clickcount++;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (clicker_text != null)
            {
                clicker_text.Text = _clickcount.ToString();
            }
        }
        private void clicker_Click(object sender, EventArgs e)
        {
            IncrementClick();
        }

        private void clicker_Click_1(object sender, EventArgs e)
        {
            IncrementClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (clicker_text != null)
            {
                int.TryParse(clicker_text.Text, out _clickcount);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

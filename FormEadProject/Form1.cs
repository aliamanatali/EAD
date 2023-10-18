using System.Text;

namespace FormEadProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                label5.Text = textBox1.Text;
            }
            else
            {
                label5.Text = "Empty Field";
            }
            if (textBox2 != null)
            {
                label4.Text = textBox2.Text;
            }
            else
            {
                label4.Text = "Empty Field";
            }
            if (textBox3.Lines.Count() < 2)
            {
                label6.Text = "Enter Atleast 2 Courses";
            }
            else
            {
                
                label6.Text = textBox3.Text;

            }

            if (checkBox1.Checked)
            {
                label7.Text = "Checked";
            }
            else
            {
                label7.Text = "UnChecked";
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
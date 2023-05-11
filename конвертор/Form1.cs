using System.Text;

namespace конвертор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            if(radioButton1.Checked )
            {
                textBox2.Text = $" {(a * 10)*16.38}";
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = $" {a * 16.38}";
            }
            if (radioButton3.Checked)
            {
                textBox2.Text = $" {a * 0.41}";
            }
            if (radioButton4.Checked)
            {
                textBox2.Text = $" {a * 4.27 / 1000 }";
            }
            if (radioButton5.Checked)
            {
                textBox2.Text = $" {a * 12.797 / 1000}";
            }
            if (radioButton6.Checked)
            {
                textBox2.Text = $" {a * 0.044 / 1000}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox2.Text = $" {(a * 10) * 16.38 * 1000}";
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = $" {a * 16.38 * 1000}";
            }
            if (radioButton3.Checked)
            {
                textBox2.Text = $" {a * 0.41 * 1000}";
            }
            if (radioButton4.Checked)
            {
                textBox2.Text = $" {a * 4.27 }";
            }
            if (radioButton5.Checked)
            {
                textBox2.Text = $" {a * 12.797 }";
            }
            if (radioButton6.Checked)
            {
                textBox2.Text = $" {a * 0.044 }";
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
          
                {
                    string text = textBox2.Text;
                    SaveFileDialog open = new SaveFileDialog();

                    open.ShowDialog();

                    string path = open.FileName;

                    try
                    {

                        using (FileStream fs = File.Create(path))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(text);
                            fs.Write(info, 0, info.Length);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
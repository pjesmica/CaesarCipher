using CaesarCipher;

namespace CaeserCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long shift = Convert.ToInt64(textBox3.Text);
                if (shift < 0) {
                    throw new ArgumentException("Shift must be a positive number!");
                }
                string text = textBox1.Text;
                textBox2.Text = Caesar.Encrypt(text, shift);
            } catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid argument: "+ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Error: Number is too large.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Error: "+ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                long shift = Convert.ToInt64(textBox3.Text);
                if (shift < 0)
                {
                    throw new ArgumentException("Shift must be a positive number!");
                }
                string text = textBox1.Text;
                textBox2.Text = Caesar.Decrypt(text, shift);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid argument: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("Error: Number is too large.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

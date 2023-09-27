namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the selected shape
            string shape = shapeSelect.SelectedItem.ToString();

            //get the input values
            try
            {
                //confirm input data type
                double length = Convert.ToDouble(inputLength.Text);
                double width = Convert.ToDouble(inputWidth.Text);
                double height = Convert.ToDouble(inputHeight.Text);

                //perform area calculations
                if (shape == "Square")
                {
                    double area = length * width;
                    inputArea.Text = area.ToString();
                }
                else if (shape == "Triangle")
                {
                    double area = (length * width) / 2;
                    inputArea.Text = area.ToString();
                }
                else if (shape == "Circle")
                {
                    double area = Math.PI * Math.Pow(length, 2);
                    inputArea.Text = area.ToString();
                }

                //output the answer
                outputAnswer.Text = "The area of the " + shape + " is " + inputArea.Text;

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        //when combo box option is selected, show the appropriate input boxes
        private void shapeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeSelect.SelectedItem.ToString() == "Square")
            {
                inputLength.Visible = true;
                inputWidth.Visible = true;
                inputHeight.Visible = false;
                inputArea.Visible = false;
            }
            else if (shapeSelect.SelectedItem.ToString() == "Triangle")
            {
                inputLength.Visible = true;
                inputWidth.Visible = true;
                inputHeight.Visible = true;
                inputArea.Visible = false;
            }
            else if (shapeSelect.SelectedItem.ToString() == "Circle")
            {
                inputLength.Visible = true;
                inputWidth.Visible = false;
                inputHeight.Visible = false;
                inputArea.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
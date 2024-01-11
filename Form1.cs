namespace _26.Leap_Year_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtYear.Text) % 4 == 0)
            {
                lblResult.Text = "Leap Year";
            }
            else
            {
                lblResult.Text = "Not a leap year";
            }
        }
    }
}
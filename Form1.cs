namespace WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Contains_Click(object sender, EventArgs e)
        {
            lb_Contains.Text = TextBox.Text.Contains("Hello").ToString(); 
            lb_Equals.Text = TextBox.Text.Equals("Hello").ToString();
            lb_Length.Text = TextBox.Text.Length.ToString();
            lb_ToLower.Text = TextBox.Text.ToLower();
            lb_ToUpper.Text = TextBox.Text.ToUpper();
        }

        private void bt_Init_Click(object sender, EventArgs e)
        {
            lb_Contains.Text = "-";
            lb_Equals.Text = "-";
            lb_Length.Text = "-";
            lb_ToLower.Text = "-";
            lb_ToUpper.Text = "-";
        }
    }
}

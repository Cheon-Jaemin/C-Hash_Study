namespace WinForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            string Order = "";
            lb_order.Text = "";

            if (ckbPencil.Checked == true)
            {
                Order += ckbPencil.Text + "\n";
            }
            if (ckbSharp.Checked == true)
            {
                Order += ckbSharp.Text + "\n";
            }
            if (ckbPen.Checked == true)
            {
                Order += ckbPen.Text + "\n";
            }
            if (ckbColor.Checked == true)
            {
                Order += ckbColor.Text + "\n";
            }
            if (ckbNote.Checked == true)
            {
                Order += ckbNote.Text + "\n";
            }

            lb_order.Text = Order + "상품을 선택하셨습니다.";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(radio_yes.Checked == true)
            {
                MessageBox.Show("봉투를 구매하셨습니다.");
            }
            else if (Radio_no.Checked == true)
            {
                MessageBox.Show("봉투를 구매하지 않았습니다.");
            }
            else
            {
                MessageBox.Show("봉투구매여부를 확인하세요.");
            }
        }
    }
}

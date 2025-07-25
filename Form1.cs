namespace FirstFormApplication
{
    public partial class Form1 : Form
    {
        DateTime startDateTime; //DateTime 구조체로 변수 선언
        public Form1()
        {
            InitializeComponent();
            startDateTime = DateTime.Now;   //구조체 변수 초기화
        }
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }
    }
}

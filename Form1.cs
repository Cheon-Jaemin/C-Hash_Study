namespace FirstFormApplication
{
    public partial class Form1 : Form
    {
        DateTime startDateTime; //DateTime ����ü�� ���� ����
        public Form1()
        {
            InitializeComponent();
            startDateTime = DateTime.Now;   //����ü ���� �ʱ�ȭ
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

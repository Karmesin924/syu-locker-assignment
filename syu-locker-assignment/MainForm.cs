namespace syu_locker_assignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ReservationFormButton.Click += ReservationFormButton_Click;
            ReturnFormButton.Click += ReturnFormButton_Click;
        }

        private void ReservationFormButton_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show(); // ���� �����ֵ��� ����
        }

        private void ReturnFormButton_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm();
            returnForm.Show(); // ���� �����ֵ��� ����
        }
    }
}

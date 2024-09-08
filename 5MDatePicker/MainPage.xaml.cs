namespace _5MDatePicker
{
    public partial class MainPage : ContentPage
    {

        

        public MainPage()
        {
            InitializeComponent();
            DateTime dt = new DateTime(2024, 1, 2);
            dpDate1.Date = dt;

        }

        private void onDateSelected(object sender, EventArgs e)
        {
            DateTime data = dpDate.Date;
            lblData.Text = data.ToString("yyyy/MM/dd");
        }



    }
}

namespace WFHW_5
{
    public partial class Form1 : Form
    {
        public List<Car> Cars = new List<Car>(); 
        private int _currentIndex = -1;
        public Form1()
        {
            InitializeComponent();
            InitializeCars();
        }

        private void InitializeCars()
        {
            Cars.Add(new Car("BMW", "X5", 2019, 3.0f, Resource.BMWX5));
            Cars.Add(new Car("Toyota", "Prius", 2019, 1.8f, Resource.Prius));
            Cars.Add(new Car("Tesla", "CyberTruck", 2019, 0.0f, Resource.CyberTruck));
        }

        private void CalculateIndex()
        {
            if(Cars.Count == 0)
            {
                _currentIndex = -1;
                return;
            }

            _currentIndex++;
            if(_currentIndex >= Cars.Count)
                _currentIndex = 0;
        }


        private void DisplayNextCar()
        {
            CalculateIndex();
            if (_currentIndex != -1)
                ChangeValue(Cars[_currentIndex]);
            else
                MessageBox.Show("No Cars Exist...");
        }


        private void ChangeValue(Car car)
        {
            tBox_Engine.Text = car.Engine.ToString();
            tBox_Model.Text = car.Model;
            tBox_Vendor.Text = car.Vendor;
            tBox_Year.Text =  car.Year.ToString();
            pic_Car.Image = car.CarImage;
        }

        private void btn_Change_Click(object sender, EventArgs e)
            => DisplayNextCar();
    }
}
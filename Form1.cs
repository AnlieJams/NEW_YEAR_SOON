namespace Form1
{
    public partial class MainForm : Form
    {
        private DateTime targetDateTime;
        private Timer timer; 

        public MainForm()
        {
            InitializeComponent();

           
            targetDateTime = new DateTime(2023, 12, 31, 23, 59, 59);

            
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

           
            UpdateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            UpdateTime();
        }

        private void UpdateTime()
        {
            
            TimeSpan remainingTime = targetDateTime - DateTime.Now;

            
            labelTimeRemaining.Text = $"{remainingTime.Days} äíåé {remainingTime.Hours} ÷àñîâ {remainingTime.Minutes} ìèíóò {remainingTime.Seconds} ñåêóíä";

           
            if (remainingTime.TotalSeconds <= 0)
            {
                labelTimeRemaining.Text = "Îòñ÷åò çàâåðøåí";
                timer.Stop(); 
            }
        }
    }
}

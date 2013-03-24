using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0, k=0;
        private static System.Timers.Timer aTimer;

        public MainWindow()
        {
            InitializeComponent();


            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            DispatcherTimer dispatcherTimer2 = new DispatcherTimer();
            ProgressBar progressBar = new ProgressBar();

           
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick); 
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            dispatcherTimer2.Tick += new EventHandler(dispatcherTimer_Tick2);
            dispatcherTimer2.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer2.Start();

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.Interval = 100;
            aTimer.Enabled = true;
          
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                textBox4.Text = k.ToString();
                progressBar.Value = k;
                k++;
            })); 
            
        }

        private void dispatcherTimer_Tick2(object sender, EventArgs e)
        {
           
            textBox3.Text = i.ToString();
            i++;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;

            textBox2.Text = date1.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            DateTime date1 = DateTime.Now;
        
            textBox1.Text =  date1.ToString();

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace OOP_Auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vehicle auto1;
        Vehicle auto2;
        DispatcherTimer timer;

        public MainWindow()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += Timer_Tick;

            InitializeComponent();
            auto1 = new Vehicle("Škoda");
            auto1.Type = "Osobní auto";
            ShowVehicle(auto1, txt1);

            auto2 = new Vehicle("VW");
            auto2.Type = "Dodávka";
            ShowVehicle(auto2, txt2);
            // auto1.Brand = "Ferrari";

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            auto1.Move();
            auto2.Move();
            ShowVehicle(auto1, txt1);
            ShowVehicle(auto2, txt2);
        }

        public void ShowVehicle(Vehicle vehicle, TextBox textBox)
        {
            textBox.Text = $"Brand: {vehicle.Brand}\n";
            textBox.Text += $"Type: {vehicle.Type}\n";
            textBox.Text += $"Fuel: {vehicle.Fuel}\n";
            textBox.Text += $"Engine volume: {vehicle.EngineVolume}\n";
            textBox.Text += $"Fuel level: {vehicle.FuelLevel}\n";
            textBox.Text += $"Distance: {vehicle.Distance}\n";
            textBox.Text += $"Pneu state: {Math.Round(vehicle.PneuState, 2)}\n";
            textBox.Text += $"Speed: {vehicle.Speed}\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            //auto1.Move();
            //auto2.Move();
            //ShowVehicle(auto1, txt1);
            //ShowVehicle(auto2, txt2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            auto1.SpeedUp();
            ShowVehicle(auto1, txt1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            auto1.SpeedDown();
            ShowVehicle(auto1, txt1);
        }
    }
}

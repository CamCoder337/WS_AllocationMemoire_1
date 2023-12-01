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
using dll_pointCore;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CLpoint> points = new List<CLpoint>();
        CLvoyage voyage = new CLvoyage();
        CLpoint point1 = new CLpoint(1, 1);
        CLpoint point2 = new CLpoint(2, 2);
        
        public MainWindow()
        {
            //Title="App GUI" Height="450" Width="800"
            InitializeComponent();
            Title = "Travel App";
            Height = 450;
            Width = 600;
            Background = Brushes.Gainsboro;
            lstPoints.Items.Add($"P{voyage.Points.Count+1}: ({point1.X}, {point1.Y})");
            voyage.addPoint(point1);
            lstPoints.Items.Add($"P{voyage.Points.Count+1}: ({point2.X}, {point2.Y})");
            voyage.addPoint(point2);
        }

        private void DistanceClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Distance du voyage : {voyage.distanceVoyage()}");
        }
        
        private void AddPointClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                CLpoint point = new CLpoint(x, y);
                // points.Add(point);
                lstPoints.Items.Add($"P{voyage.Points.Count+1}: ({point.X}, {point.Y})");
                voyage.addPoint(point);
            }
            else
            {
                MessageBox.Show("Please enter valid value for X and Y.");
            }
        }
        
        private void MovePointClick(object sender, RoutedEventArgs e)
        {
            if (lstPoints.SelectedItem == null)
            {
                MessageBox.Show("Select a Point to Move.");
            }
            else
            {
                int selectedIndex = lstPoints.SelectedIndex;
                voyage.pointMove(selectedIndex);
                lstPoints.Items[selectedIndex] =
                    $"P{voyage.Points[selectedIndex].ID + 1}: ({voyage.Points[selectedIndex].X}, {voyage.Points[selectedIndex].Y})";
            }
            
        }

        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            if (lstPoints.SelectedItem != null)
            {
                int selectedIndex = lstPoints.SelectedIndex;
                // points.RemoveAt(selectedIndex);
                lstPoints.Items.RemoveAt(selectedIndex);
                voyage.delPoint(selectedIndex);
            }
        }
    }
}
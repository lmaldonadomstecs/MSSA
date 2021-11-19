using System;
using System.ComponentModel;
using System.Diagnostics;
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

namespace CoffeeRecreate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string size;
        string extras;
        Coffee coffee = new Coffee();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = coffee;
        }        

        private void updateOrderSummary(object sender, EventArgs e)
        {
            if(orderSummary != null)
            {
                if(small.IsChecked == true)
                {
                    this.size = small.Content.ToString();
                } else if (medium.IsChecked == true)
                {
                    this.size = medium.Content.ToString();
                } else
                {
                    this.size = large.Content.ToString();
                }
                if(sugar.IsChecked == true && cream.IsChecked == true)
                {
                    this.extras = $"with {sugar.Content.ToString().ToLower()} and {cream.Content.ToString().ToLower()}";
                } else if(sugar.IsChecked == true)
                {
                    this.extras = $"with {sugar.Content.ToString().ToLower()}";
                } else if (cream.IsChecked == true)
                {
                    this.extras = $"with {cream.Content.ToString().ToLower()}";
                } else
                {
                    this.extras = null;
                }
                coffee.Order = $"{this.size} {coffeeList.SelectedValue.ToString()} {this.extras}";
                orderBtn.IsEnabled = true;
            }
        }

        private void orderCoffee(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Order placed for a : {orderSummary.Text}");
            orderSummary.Text = "Please choose a coffee.";
            orderBtn.IsEnabled = false;
        }
    }
    class Coffee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string order;
        public string Order
        {
            get { return order; } 
            set { order = value; updateUI(); }
        }
        public void updateUI(string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}

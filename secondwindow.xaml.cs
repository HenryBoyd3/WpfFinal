using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfFinal
{
    /// <summary>
    /// Interaction logic for secondwindow.xaml
    /// </summary>
    public partial class secondwindow : Window
    {
        public secondwindow()
        {
            InitializeComponent();
        }
        private void firstWindow_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow(); 
            newForm.Show(); 
            this.Close(); 
        }
        private void thirdWindow_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new thirdwindow();
            newForm.Show();
            this.Close(); 
        }
    }
}

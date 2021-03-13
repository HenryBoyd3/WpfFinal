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
    /// Interaction logic for thirdwindow.xaml
    /// </summary>
    public partial class thirdwindow : Window
    {
        public thirdwindow()
        {
            InitializeComponent();
        }

        private void secondWindow_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new secondwindow();
            newForm.Show();
            this.Close();
        }
        private void firstWindow_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow(); 
            newForm.Show();
            this.Close();
        }
    }
}

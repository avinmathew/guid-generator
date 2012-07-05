using System;
using System.Windows;

namespace GuidGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGuid_Click(object sender, RoutedEventArgs e)
        {
            Guid guid = Guid.NewGuid();
            string guidString = guid.ToString();
            txtGuid.Text = guidString;
            Clipboard.SetText(guidString);
        }
    }
}

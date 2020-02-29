using System.Windows;
using Recademy.Desktop.View;

namespace Recademy.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new UserProfileView();
        }
    }
}

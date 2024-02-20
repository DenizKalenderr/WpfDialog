using System.Windows;
using WpfDialog.View;

namespace WpfDialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new();
            // Diğer ekranlarda çalışılmasına izin verir.
            normalWindow.Show();
        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            ModelWindow modelWindow = new(this);
            Opacity = 0.4;
            // Diğer ekranlarda çalışılmasına izin vermez.
            modelWindow.ShowDialog();
            Opacity = 1;
            if (modelWindow.Success)
            {
                txtInput.Text = modelWindow.Input;
            }
        }
    }
}
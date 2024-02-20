using System.Windows;

namespace WpfDialog.View
{

    public partial class ModelWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }
        public ModelWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // txtInput boşsa ok butonu devredışı, doluysa devredışı değil.
        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInput.Text)) 
            { 
                btnOk.IsEnabled = true;
            }
            else
            {
                btnOk.IsEnabled = false;
            }
        }
    }
}

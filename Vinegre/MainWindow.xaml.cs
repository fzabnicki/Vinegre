using System.Windows;

namespace Vinegre
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, RoutedEventArgs e)
        {
            Decoder d = new Decoder();
            if (codeRadioBtn.IsChecked == true)
                outputTextBox.Text = d.Algorythm(inputTextBox.Text, keyTextBox.Text, true);
            else if(decodeRadioBtn.IsChecked == true)
                outputTextBox.Text = d.Algorythm(inputTextBox.Text, keyTextBox.Text, false);
            else
                MessageBox.Show("Wybierz rodzaj operacji.");
        }
    }
}

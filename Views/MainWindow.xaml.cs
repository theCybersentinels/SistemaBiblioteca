using System.Windows;
using System.Windows.Controls;

namespace SistemaBiblioteca
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tabControl.IsEnabled = false; // Deshabilitar las pestañas al inicio
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Password;

            // Verificar las credenciales del usuario (modifica esto según tu lógica)
            if (usuario == "admin" && contraseña == "1234")
            {
                tabControl.IsEnabled = true; // Habilitar las pestañas
                txtUsuario.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == (string)textBox.Tag)
            {
                textBox.Clear(); // Limpiar el texto de indicación
                textBox.Foreground = System.Windows.Media.Brushes.Black; // Cambiar color del texto
            }
        }

        private void Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = (string)textBox.Tag; // Restablecer el texto de indicación
                textBox.Foreground = System.Windows.Media.Brushes.Gray; // Cambiar color de indicación
            }
        }
    }
}

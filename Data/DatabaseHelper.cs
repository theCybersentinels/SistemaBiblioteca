using System;
using System.Data.SQLite; // Espacio de nombres para SQLite
using System.Windows;

namespace SistemaBiblioteca
{
    public partial class MainWindow : Window
    {
        // Cadena de conexión a la base de datos SQLite
        private string connectionString = "Data Source=biblioteca.db;Version=3;";

        public MainWindow()
        {
            InitializeComponent();
            ProbarConexion();
        }

        // Método para probar la conexión a la base de datos
        private void ProbarConexion()
        {
            try
            {
                // Usamos la instrucción using para garantizar que la conexión se cierre automáticamente
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open(); // Abrimos la conexión

                    // Mensaje de confirmación de conexión exitosa
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
            }
            catch (SQLiteException sqlEx)
            {
                // Manejamos errores específicos de SQLite
                MessageBox.Show($"Error de SQLite: {sqlEx.Message}", "Error de Conexión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                // Manejamos cualquier otro tipo de error
                MessageBox.Show($"Error general de conexión: {ex.Message}", "Error de Conexión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

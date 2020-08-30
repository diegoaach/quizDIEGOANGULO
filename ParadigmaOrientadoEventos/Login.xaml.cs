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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParadigmaOrientadoEventos
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text.ToLower() == "diego" && txtPassword.Password == "1234") 
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new home());
            }
            else 
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtUsername.Text.ToLower() == "diego" && txtPassword.Password == "1234")
                {
                    MainWindow w = (MainWindow)Window.GetWindow(this);
                    w.frameMain.NavigationService.Navigate(new home());
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }

            }


        }
    }
}

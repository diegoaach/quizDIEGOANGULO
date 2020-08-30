using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Lógica de interacción para home.xaml
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(txtGameName.Text==null ^ calReleaseDate.SelectedDate == null)
            {
                MessageBox.Show("Lacking game name or release date ");

            }
            else
            {

                string productName = txtGameName.Text;
                txtGames.AppendText(productName + "   Genre: " + cbxGenre.Text + "    Release Date: " + calReleaseDate.SelectedDate.Value.ToString("dd/MM/yyyy") + " ");

                if (ckbBuyGame.IsChecked.Value == true)
                {
                    txtGames.AppendText("Will buy \n");
                }
                else
                {
                    txtGames.AppendText("Won't buy \n");
                }

                txtGameName.Text = null;
                calReleaseDate.SelectedDate = null;
                cbxGenre.SelectedIndex = -1;
                ckbBuyGame.IsChecked = false;
            }




        }

        private void txtGameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtGameName.Text == null ^ calReleaseDate.SelectedDate == null)
                {
                    MessageBox.Show("Lacking game name or release date ");

                }
                else
                {

                    
                    txtGames.AppendText(txtGameName.Text + "   Genre: " + cbxGenre.Text + "    Release Date: " + calReleaseDate.SelectedDate.Value.ToString("dd/MM/yyyy") + " ");

                    if (ckbBuyGame.IsChecked.Value == true)
                    {
                        txtGames.AppendText("Will buy \n");
                    }
                    else
                    {
                        txtGames.AppendText("Won't buy \n");
                    }

                    txtGameName.Text = null;
                    calReleaseDate.SelectedDate = null;
                    cbxGenre.SelectedIndex = -1;
                    ckbBuyGame.IsChecked = false;
                }
            }

        }
        

        private void ckbBuyGame_Click(object sender, RoutedEventArgs e)
        {
            ckbBuyGame.IsChecked = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OXOX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool player1Turn = true;
        public bool player2Turn = false;
        public bool Win = false;
        private string player1Naam;
        private string player2Naam;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void spelerNamen()
        {
            player1Naam = Interaction.InputBox("Speler 1 geef je naam", "Naam Speler1", "Player 1", 250, 200);
            if (player1Naam.Length > 0)
            {
                LblPlayer1Naam.Content = player1Naam;
            }
            else
            {
                LblPlayer1Naam.Content = "Player 1";
            }
            player2Naam = Interaction.InputBox("Speler 2 geef je naam", "Naam Speler2", "Player 2", 250, 200);
            LblPlayer2Naam.Content = player2Naam.Length > 0 ? player2Naam : "Player 2";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            spelerNamen();
        }

        private void BoterKaasEieren(int btnPos)
        {
            switch (btnPos)
            {
                case 1:
                    if (player1Turn)
                    {
                        Btn00.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn00.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn00.IsEnabled = false;
                    break;
                case 2:
                    if (player1Turn)
                    {
                        Btn01.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn01.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn01.IsEnabled = false;
                    break;
                case 3:
                    if (player1Turn)
                    {
                        Btn02.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn02.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn02.IsEnabled = false;
                    break;
                case 4:
                    if (player1Turn)
                    {
                        Btn10.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn10.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn10.IsEnabled = false;
                    break;
                case 5:
                    if (player1Turn)
                    {
                        Btn11.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn11.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn11.IsEnabled = false;
                    break;
                case 6:
                    if (player1Turn)
                    {
                        Btn12.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn12.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn12.IsEnabled = false;
                    break;
                case 7:
                    if (player1Turn)
                    {
                        Btn20.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn20.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn20.IsEnabled = false;
                    break;
                case 8:
                    if (player1Turn)
                    {
                        Btn21.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn21.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn21.IsEnabled = false;
                    break;
                case 9:
                    if (player1Turn)
                    {
                        Btn22.Content = "X";
                        player1Turn = false;
                        player2Turn = true;
                    }
                    else
                    {
                        Btn22.Content = "O";
                        player1Turn = true;
                        player2Turn = false;
                    }
                    Btn22.IsEnabled = false;
                    break;
                default:
                    break;
            }
        }

        private void Btn00_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(1);
        }

        private void Btn01_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(2);
        }

        private void Btn02_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(3);
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(4);
        }

        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(5);
        }

        private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(6);
        }

        private void Btn20_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(7);
        }

        private void Btn21_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(8);
        }

        private void Btn22_Click(object sender, RoutedEventArgs e)
        {
            BoterKaasEieren(9);
        }
    }
}

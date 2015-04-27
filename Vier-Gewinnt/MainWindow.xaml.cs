using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vier_Gewinnt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private char _Spieler = 'X';
        public MainWindow()
        {
            InitializeComponent();
            TextBox2.Text = "Nächster \r\n Spieler:";
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Button _btn = sender as Button;
            int _column = (int)_btn.GetValue(Grid.ColumnProperty);
            if (_column == null)
            {
                throw new Exception("Kackmist");
            } 
            SpalteGeklickt(_column);
            if (_Spieler == 'X')
            {
                _Spieler = 'Y';
                string Spieler = string.Format("{0}", _Spieler);
                TextBox.Text = Spieler;
            }
            else
            {
                _Spieler = 'X';
                string Spieler = string.Format("{0}", _Spieler);
                TextBox.Text = Spieler;
            }
        }

        private void SpalteGeklickt(Int32 Column)
        {
            if (Column == 0)                        //Spalte 1 (0) angeklickt
            {
                if (a0.Content == null)                                 //Zeile 1 kein Content
                {
                    a0.Content = _Spieler;
                    CheckForWin(0, 0);
                } else if (b0.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b0.Content = _Spieler;
                    CheckForWin(0, 1);
                }
                else if (c0.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c0.Content = _Spieler;
                    CheckForWin(0, 2);
                }
                else if (d0.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d0.Content = _Spieler;
                    CheckForWin(0, 3);
                }
                else if (e0.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e0.Content = _Spieler;
                    CheckForWin(0, 4);
                }
                else if (f0.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f0.Content = _Spieler;
                    CheckForWin(0, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist
                    return;
                }
            }

                //-------------------------------------------------------------------------------------------------

            else if (Column == 1)               //Spalte 2 (1) angeklickt
            {
                if (a1.Content == null)                                 //Zeile 1 kein Content
                {
                    a1.Content = _Spieler;
                    CheckForWin(1, 0);
                } else if (b1.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b1.Content = _Spieler;
                    CheckForWin(1, 1);
                }
                else if (c1.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c1.Content = _Spieler;
                    CheckForWin(1, 2);
                }
                else if (d1.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d1.Content = _Spieler;
                    CheckForWin(1, 3);
                }
                else if (e1.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e1.Content = _Spieler;
                    CheckForWin(1, 4);
                }
                else if (f1.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f1.Content = _Spieler;
                    CheckForWin(1, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist 
                    return;
                }
            }

                //-------------------------------------------------------------------------------------

            else if (Column == 2)
            {
                if (a2.Content == null)                                 //Zeile 1 kein Content
                {
                    a2.Content = _Spieler;
                    CheckForWin(2, 0);
                } else if (b2.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b2.Content = _Spieler;
                    CheckForWin(2, 1);
                }
                else if (c2.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c2.Content = _Spieler;
                    CheckForWin(2, 2);
                }
                else if (d2.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d2.Content = _Spieler;
                    CheckForWin(2, 3);
                }
                else if (e2.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e2.Content = _Spieler;
                    CheckForWin(2, 4);
                }
                else if (f2.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f2.Content = _Spieler;
                    CheckForWin(2, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist 
                    return; 
                }
            }

                //------------------------------------------------------------------------------------------------

            else if (Column == 3)
            {
                if (a3.Content == null)                                 //Zeile 1 kein Content
                {
                    a3.Content = _Spieler;
                    CheckForWin(3, 0);
                } else if (b3.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b3.Content = _Spieler;
                    CheckForWin(3, 1);
                }
                else if (c3.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c3.Content = _Spieler;
                    CheckForWin(3, 2);
                }
                else if (d3.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d3.Content = _Spieler;
                    CheckForWin(3, 3);
                }
                else if (e3.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e3.Content = _Spieler;
                    CheckForWin(3, 4);
                }
                else if (f3.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f3.Content = _Spieler;
                    CheckForWin(3, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist
                    return;
                }
            }

                //------------------------------------------------------------------------------------------------

            else if (Column == 4)
            {
                if (a4.Content == null)                                 //Zeile 1 kein Content
                {
                    a4.Content = _Spieler;
                    CheckForWin(4, 0);
                } else if (b4.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b4.Content = _Spieler;
                    CheckForWin(4, 1);
                }
                else if (c4.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c4.Content = _Spieler;
                    CheckForWin(4, 2);
                }
                else if (d4.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d4.Content = _Spieler;
                    CheckForWin(4, 3);
                }
                else if (e4.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e4.Content = _Spieler;
                    CheckForWin(4, 4);
                }
                else if (f4.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f4.Content = _Spieler;
                    CheckForWin(4, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist
                    return;
                }
            }

                //------------------------------------------------------------------------------------------------

            else if (Column == 5)
            {
                if (a5.Content == null)                                 //Zeile 1 kein Content
                {
                    a5.Content = _Spieler;
                    CheckForWin(5, 0);
                } else if (b5.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b5.Content = _Spieler;
                    CheckForWin(5, 1);
                }
                else if (c5.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c5.Content = _Spieler;
                    CheckForWin(5, 2);
                }
                else if (d5.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d5.Content = _Spieler;
                    CheckForWin(5, 3);
                }
                else if (e5.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e5.Content = _Spieler;
                    CheckForWin(5, 4);
                }
                else if (f5.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f5.Content = _Spieler;
                    CheckForWin(5, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist
                    return;
                }
            }

                //------------------------------------------------------------------------------------------------

            else if (Column == 6)
            {
                if (a6.Content == null)                                 //Zeile 1 kein Content
                {
                    a6.Content = _Spieler;
                    CheckForWin(6, 0);
                } else if (b6.Content == null)                          //Zeile 1 Content, Zeile 2 kein Content
                {
                    b6.Content = _Spieler;
                    CheckForWin(6, 1);
                }
                else if (c6.Content == null)                            //Zeile 1,2 Content, Zeile 3 kein Content
                {
                    c6.Content = _Spieler;
                    CheckForWin(6, 2);
                }
                else if (d6.Content == null)                            //Zeile 1-3 Content, Zeile 4 kein Content
                {
                    d6.Content = _Spieler;
                    CheckForWin(6, 3);
                }
                else if (e6.Content == null)                            //Zeile 1-4 Content, Zeile 5 kein Content
                {
                    e6.Content = _Spieler;
                    CheckForWin(6, 4);
                }
                else if (f6.Content == null)                            //Zeile 1-5 Content, Zeile 6 kein Content
                {
                    f6.Content = _Spieler;
                    CheckForWin(6, 5);
                }
                else
                {
                    MessageBox.Show("NEIN NEIN NEIN NEIN NEIN!!!");     //Wenn Spalte Voll ist 
                    return;
                }
            }
        }

        private void CheckForWin(Int32 X, Int32 Y)                      //Erhält Position der Buttons (X,Y)
        {
            int[,] Gesetzt = { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
            if (_Spieler == 'X')
            {
                Gesetzt[X, Y] = 1;
            } else
            {
                Gesetzt[X, Y] = 2;
            }
        }
    }
}
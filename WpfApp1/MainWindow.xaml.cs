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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        bool turn = true;
        static bool isWin = false;

        public MainWindow()
        {
            InitializeComponent();
            FirstBut.Content = null;
            SecondBut.Content = null;
            ThirdBut.Content = null;
            FourthBut.Content = null;
            FifthBut.Content = null;
            SixthBut.Content = null;
            SeventhBut.Content = null;
            EigthBut.Content = null;
            NineBut.Content = null;
        }

        private void ButtClick(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;

            if (isWin == false)
            {
                if (but.Content == null)
                {
                    if (turn == true)
                    {
                        but.Content = "X";
                        turn = false;
                        CheckWin();
                    }
                    else if (turn == false)
                    {
                        but.Content = "O";
                        turn = true;
                        CheckWin();
                    }
                }
            }
            else if (isWin == true)
            {
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                FourthBut.Content = null;
                FifthBut.Content = null;
                SixthBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = false;
            }
        }

        private void CheckWin()
        {
            if (FirstBut.Content == SecondBut.Content && FirstBut.Content == ThirdBut.Content && FirstBut.Content != null)
            {
                FifthBut.Content = FirstBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (FourthBut.Content == FifthBut.Content && FifthBut.Content == SixthBut.Content && FourthBut.Content != null)
            {
                FifthBut.Content = FourthBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (SeventhBut.Content == EigthBut.Content && EigthBut.Content == NineBut.Content && SeventhBut.Content != null)
            {
                FifthBut.Content = SeventhBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (FirstBut.Content == FourthBut.Content && FourthBut.Content == SeventhBut.Content && FirstBut.Content != null)
            {
                FifthBut.Content = FirstBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (SecondBut.Content == FifthBut.Content && FifthBut.Content == EigthBut.Content && SecondBut.Content != null)
            {
                FifthBut.Content = SecondBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (ThirdBut.Content == SixthBut.Content && SixthBut.Content == NineBut.Content && ThirdBut.Content != null)
            {
                FifthBut.Content = ThirdBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (FirstBut.Content == FifthBut.Content && FifthBut.Content == NineBut.Content && FirstBut.Content != null)
            {
                FifthBut.Content = FirstBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
            else if (ThirdBut.Content == FifthBut.Content && FifthBut.Content == SeventhBut.Content && ThirdBut.Content != null)
            {
                FifthBut.Content = ThirdBut.Content;
                FourthBut.Content = "The";
                SixthBut.Content = "Won !";
                FirstBut.Content = null;
                SecondBut.Content = null;
                ThirdBut.Content = null;
                SeventhBut.Content = null;
                EigthBut.Content = null;
                NineBut.Content = null;
                isWin = true;
            }
        }
    }
}

/* Ethan Shipston
 * ICS4U
 * June 17 2019
 * A program which calculates the sum of every multiple of 3 and 5 below 1000.
 */
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

namespace _184988Multiples_of_3_and_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int[] threes = new int[334];
            int[] fives = new int[200];
            for (int i = 0; i < 200; i++)
            {
                fives[i] = 5 * i;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 334; i++)
            {
                threes[i] = 3 * i;
                if (fives.Contains(threes[i]))
                    threes[i] = 0;
                Console.WriteLine(i);
            }
            int total = threes.Sum() + fives.Sum();
            MessageBox.Show(threes.Sum().ToString() + " + " + fives.Sum().ToString() + " ="  + total.ToString());
        }
    }
}

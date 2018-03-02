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
using System.Windows.Shapes;

namespace CSharp_WPF.CodeSamples
{
    public partial class HalloWorld : Window
    {
        /* Made by Jesper Ahasverusen Kielsgaard
         * Date: 02-03-2018
         * 
         * A quick sample how to make a window and
         * how a button is used
         */

        public HalloWorld()
        {
            // All code here will be loaded beforce the window will loaded
            // If any of UI need to be change in the loading (before user see it)
            // Use the "loaded" event on the window
            InitializeComponent();
        }

        private void btn_Hallo_Click(object sender, RoutedEventArgs e)
        {
            // JAK - Will popup a messagebox when the user click the button
            MessageBox.Show("World");
        }
    }
}

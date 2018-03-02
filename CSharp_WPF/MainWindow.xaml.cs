using CSharp_WPF.CodeSamples;
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

namespace CSharp_WPF
{
        /* MADE AND DOCUMENTED THE 02-03-2018 BY
         * Jesper Ahasverusen Kielsgaard
         * 
         * MainWindow.xaml and MainWindow.cs will contian a button that can to set to show the 
         * the window where the CodeSample is, so this MainWindow will be a clean CodeSample
         * 
         * Remenber to document what the code due and make notes in codes
         * 
         * Make a new Window (xaml and cs) in the "CodeSamples" folder and give it a descriptive name
         * so it's easy to see what the purpose is with it.
         * If there is a Window with that name, put the code inside that and make sure to make new
         * method in it and make it easy to manageable
         * 
         * If the CodeSample file need a dll-file (See if the DLL file is in NuGet packages) or 
         * others files as a CS-file from other developer put them into the "Files" folder and 
         * call them from there and if there is more then one file (eg. one CS-file and one dll-file) 
         * make a folder with a descriptive name to the 
         * 
         * And remenber 
         *   ___ _                              _      _          _  __ _        _    ___         _     
         *  / __| |___ __ _ _ _    __ _ _ _  __| |  __| |__ _ _ _(_)/ _(_)___ __| |  / __|___  __| |___ 
         * | (__| / -_) _` | ' \  / _` | ' \/ _` | / _| / _` | '_| |  _| / -_) _` | | (__/ _ \/ _` / -_)
         *  \___|_\___\__,_|_||_| \__,_|_||_\__,_| \__|_\__,_|_| |_|_| |_\___\__,_|  \___\___/\__,_\___|                                                                                     
         *  _      _  _                        ___         _             
         * (_)___ | || |__ _ _ __ _ __ _  _   / __|___  __| |___        //  \\
         * | (_-< | __ / _` | '_ \ '_ \ || | | (__/ _ \/ _` / -_)      _\\()//_  <-- beware of the bugs
         * |_/__/ |_||_\__,_| .__/ .__/\_, |  \___\___/\__,_\___|     / //  \\ \
         *                  |_|  |_|   |__/                            | \__/ |
         *
         */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            #region Quick sample how to call/show a another Window
            // Make the to lines and press ctrl+k+c to out comment the code 
            // and ctrl+k+u to make is back again 
            HalloWorld hw = new HalloWorld();
            hw.Show();
            #endregion

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            // Environment.exit(0) will kill all process the software is running.
            // This is NOT the best way to close down software but in this case
            // we want to make sure all processes is stopped
            Environment.Exit(0);
        }
    }
}

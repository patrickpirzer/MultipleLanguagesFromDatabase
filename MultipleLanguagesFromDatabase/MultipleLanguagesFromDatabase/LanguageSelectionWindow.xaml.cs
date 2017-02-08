using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultipleLanguagesFromDatabase
{
    /// <summary>
    /// Interaction logic of LanguageSelectionWindow.xaml
    /// </summary>
    public partial class LanguageSelectionWindow : Window
    {
        /// <summary>
        /// Field for an instance of the <see cref="LanguageSelectionWindowViewModel"/> class.
        /// </summary>
        private LanguageSelectionWindowViewModel vm;

        /// <summary>
        /// Event for signalizing that the application language has changed.
        /// </summary>
        public EventHandler LanguageHasChanged;

        /// <summary>
        /// The constructor.
        /// </summary>
        public LanguageSelectionWindow()
        {
            InitializeComponent();
            vm = new LanguageSelectionWindowViewModel();
            vm.LanguageHasChanged += LanguageWasChanged;
            DataContext = vm;
        }

        ///// <summary>
        ///// Changes the application language to german.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btn_german_Click(object sender, RoutedEventArgs e)
        //{
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo(Constants.CultureGerman);
        //    vm.UpdateProperties();
        //    LanguageWasChanged();
        //}

        ///// <summary>
        ///// Changes the application language to english.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btn_english_Click(object sender, RoutedEventArgs e)
        //{
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo(Constants.CultureEnglish);
        //    vm.UpdateProperties();
        //    LanguageWasChanged();
        //}

        ///// <summary>
        ///// Signalizes that the application language was changed and executes the event.
        ///// </summary>
        //private void LanguageWasChanged()
        //{
        //    if (LanguageHasChanged != null)
        //        LanguageHasChanged(null, null);
        //}

        private void LanguageWasChanged(object sender, EventArgs e)
        {
            if (LanguageHasChanged != null)
                LanguageHasChanged(null, null);
        }

    }
}

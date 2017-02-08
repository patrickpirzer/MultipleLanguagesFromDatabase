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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultipleLanguagesFromDatabase
{
    /// <summary>
    /// Interaction logic of MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Field for an instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        private MainWindowViewModel vm;

        /// <summary>
        /// The constructor.
        /// </summary>
        public MainWindow()
        {
            // Sets the current application language to english.
            // In the final application the user's language would be read from the database.
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Constants.CultureEnglish);

            // Initializes the window.
            InitializeComponent();

            // Binds the datacontext to a new instance of the viewmodel.
            vm = new MainWindowViewModel();
            DataContext = vm;
        }

        /// <summary>
        /// Opens a window for changing the display language of the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mi_languageselection_Click(object sender, RoutedEventArgs e)
        {
            LanguageSelectionWindow lsw = new LanguageSelectionWindow();
            lsw.LanguageHasChanged += OnLanguageHasChanged;
            lsw.Show();
        }

        /// <summary>
        /// This method is executed when the language has changed in LanguageSelectionWindow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLanguageHasChanged(object sender, EventArgs e)
        {
            vm.UpdateProperties();
            // TODO Ist das nötig? : Und die ViewModels aller offenen Fenster/Tabs aktualisieren.
            //      Man könnte es auch wie im alten P16 machen, dass die Sprache nur umgestellt werden darf, wenn keine anderen Fenster offen sind.
        }

    }
}

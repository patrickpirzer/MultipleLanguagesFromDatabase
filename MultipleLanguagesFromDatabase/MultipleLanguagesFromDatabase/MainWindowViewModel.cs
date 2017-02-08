using System.ComponentModel;
using System.Threading;

namespace MultipleLanguagesFromDatabase
{
    /// <summary>
    /// Viewmodel of MainWindow.xaml.
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged, IViewModel
    {
        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string MainWindowTitle
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Hauptfenster";
                    case Constants.CultureEnglish:
                        return "Main window";
                    default:
                        return "Hauptfenster";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string SelectLanguage
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Sprachwahl";
                    case Constants.CultureEnglish:
                        return "Change language";
                    default:
                        return "Sprachwahl";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string ChangeToGerman
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Deutsch";
                    case Constants.CultureEnglish:
                        return "German";
                    default:
                        return "Deutsch";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string ChangeToEnglish
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Englisch";
                    case Constants.CultureEnglish:
                        return "English";
                    default:
                        return "Englisch";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string MenuitemProgram
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Programm";
                    case Constants.CultureEnglish:
                        return "Program";
                    default:
                        return "Programm";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string MenuitemLanguageSelection
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Sprachwahl";
                    case Constants.CultureEnglish:
                        return "Language selection";
                    default:
                        return "Sprachwahl";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string MenuitemReleaseVersion
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Freigabe / Version";
                    case Constants.CultureEnglish:
                        return "Release / Version";
                    default:
                        return "Freigabe / Version";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string MenuitemTextMaintenance
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Textpflege";
                    case Constants.CultureEnglish:
                        return "Text maintenance";
                    default:
                        return "Textpflege";
                }
            }
        }

        /// <summary>
        /// Would be read from database.
        /// </summary>
        public string MenuitemQuit
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name)
                {
                    case Constants.CultureGerman:
                        return "Beenden";
                    case Constants.CultureEnglish:
                        return "Quit";
                    default:
                        return "Beenden";
                }
            }
        }

        /// <summary>
        /// Updates all properties.
        /// </summary>
        public void UpdateProperties()
        {
            OnPropertyChanged("");
        }

        #region INotifyPropertyChanged members

        /// <summary>
        /// Event which signalizes that a property has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// EventHandler for the PropertyChanged-event.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}

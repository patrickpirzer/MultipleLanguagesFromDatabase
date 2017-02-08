using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace MultipleLanguagesFromDatabase
{
    /// <summary>
    /// Viewmodel of LanguageSelectionWindow.xaml.
    /// </summary>
    public class LanguageSelectionWindowViewModel : INotifyPropertyChanged, IViewModel
    {
        /// <summary>
        /// Event for signalizing that the application language has changed.
        /// </summary>
        public EventHandler LanguageHasChanged;

        /// <summary>
        /// Gets the window title.
        /// Would be read from database.
        /// </summary>
        public string WindowTitle
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
        /// Gets or sets if the application language is german.
        /// </summary>
        public bool? LanguageIsGerman
        {
            get
            {
                bool? result = Thread.CurrentThread.CurrentCulture.Name == Constants.CultureGerman;
                return result;
            }
            set
            {
                if (value == true)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(Constants.CultureGerman);
                    UpdateProperties();
                    LanguageHasChanged(null, null);
                }
            }
        }

        /// <summary>
        /// Gets or sets if the application language is english.
        /// </summary>
        public bool? LanguageIsEnglish
        {
            get
            {
                bool? result = Thread.CurrentThread.CurrentCulture.Name == Constants.CultureEnglish;
                return result;
            }
            set
            {
                if (value == true)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(Constants.CultureEnglish);
                    UpdateProperties();
                    LanguageHasChanged(null, null);
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

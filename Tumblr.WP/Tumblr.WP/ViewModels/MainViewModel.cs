using Caliburn.Micro;
using System;
using System.IO.IsolatedStorage;
using System.Windows.Controls;
using System.Windows.Data;

namespace Tumblr.WP.ViewModels {
    public class MainViewModel : PropertyChangedBase {

        #region fields
        private readonly INavigationService _navigationService;

        private string _blogName;
        #endregion

        #region properties
        public string BlogName
        {
            get
            {
                return _blogName;
            }
            set
            {
                if (Equals(value, _blogName))
                {
                    return;
                }
                _blogName = value;
                NotifyOfPropertyChange(() => BlogName);
                NotifyOfPropertyChange(() => CanAccept);
            }
        }        

        public bool CanAccept
        {
            get { return !String.IsNullOrEmpty(_blogName); }
        }
        #endregion

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ReadBlogNameFromSettings();
        }

        #region methods
        public void OnTextBoxTextChanged(object sender)
        {
            TextBox textBox = sender as TextBox;
            BindingExpression bindingExpr = textBox.GetBindingExpression(TextBox.TextProperty);
            bindingExpr.UpdateSource();
        }

        public void Accept()
        {
            _navigationService.For<BlogPostsViewModel>()
                .WithParam(x => x.BlogName, _blogName)
                .Navigate();
        }

        private void ReadBlogNameFromSettings()
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("blogName"))
            {
                BlogName = IsolatedStorageSettings.ApplicationSettings["blogName"] as string;
            }
        }
        #endregion
    }
}
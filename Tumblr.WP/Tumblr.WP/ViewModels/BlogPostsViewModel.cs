using Caliburn.Micro;
using Microsoft.Phone.Controls;
using Microsoft.Practices.Prism.Commands;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Windows;
using System.Windows.Input;
using Tumblr.Model;

namespace Tumblr.WP.ViewModels
{
    public class BlogPostsViewModel : PropertyChangedBase
    {
        #region fields 
        private string _blogName;
        private ObservableCollection<Post> _posts;
        private readonly INavigationService _navigationService;
        private int _availablePostsCount;
        #endregion

        #region properties
        public ICommand LoadCommand { get; set; }
        public string BlogName
        {
            get { return _blogName; }
            set
            {
                if (Equals(value, _blogName))
                {
                    return;
                }
                _blogName = value;
                NotifyOfPropertyChange(() => BlogName);
                SaveBlogName();
                DownloadNextPosts(20);
            }
        }
        public ObservableCollection<Post> Posts
        {
            get { return _posts; }
            set
            {
                if (Equals(value, _posts))
                {
                    return;
                }
                _posts = value;
                NotifyOfPropertyChange(() => Posts);
            }
        }
        #endregion        

        public BlogPostsViewModel(INavigationService navigationService)
        {            
            _navigationService = navigationService;
            Posts = new BindableCollection<Post>();
            LoadCommand = new DelegateCommand(LoadMoreItems, MoreItemsAvailable);            
        }

        #region methods
        private void DownloadNextPosts(int count = 20, int startIndex = 0)
        {
            var blogName = "discoverynews";
            var url = "http://" + _blogName + ".tumblr.com/";
            var client = new RestClient(url);
            var request = new RestRequest("api/read/json", Method.GET);
            request.AddParameter("filter", "text");
            request.AddParameter("start", startIndex);
            request.AddParameter("num", count);
            //request.AddParameter("type", "audio");
            request.AddHeader("Accept", "application/json");

            client.ExecuteAsync(request, restResponse =>
            {
                if (restResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Something goes wrong, please check the user blog name and try again.", "", MessageBoxButton.OK);
                    return;
                }
                var json = restResponse.Content.Substring(22, restResponse.Content.Length - 24);
                var deserializeObject = JsonConvert.DeserializeObject<RootObject>(json);
                _availablePostsCount = deserializeObject.PostsTotal;
                foreach (var p in deserializeObject.Posts)
                {
                    Posts.Add(p);
                }                
            });
        }
        
        private bool MoreItemsAvailable()
        {
            if (Posts.Count < _availablePostsCount) return true;
            else return false;
        }

        private void LoadMoreItems()
        {
            DownloadNextPosts(20, Posts.Count);
        }

        private void ShowPostDetails(Post post)
        {
            string json = JsonConvert.SerializeObject(post);
            _navigationService.For<BlogPostDetailsViewModel>()
                .WithParam(x => x.PostAsJson, json)
                .Navigate();
        }

        public void OnSelectionChanged(LongListSelector longList)
        {
            var post = longList.SelectedItem as Post;
            ShowPostDetails(post);
            longList.SelectedItem = null;
        }

        private void SaveBlogName()
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains("blogName"))
            {
                settings.Add("blogName", _blogName);
            }
            else
            {
                settings["blogName"] = _blogName;
            }
            settings.Save();
        }
        #endregion
    }
}

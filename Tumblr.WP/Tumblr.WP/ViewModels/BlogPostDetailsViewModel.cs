using Caliburn.Micro;
using Newtonsoft.Json;
using System;
using Tumblr.Model;

namespace Tumblr.WP.ViewModels
{
    public class BlogPostDetailsViewModel : PropertyChangedBase
    {
        #region fields
        private readonly INavigationService navigationService;
        private Post _post;        
        private String _postAsJson;
        #endregion

        #region properties
        public Post Post
        {
            get { return _post; }
            set
            {
                if (Equals(value, _post))
                {
                    return;
                }
                _post = value;
                NotifyOfPropertyChange(() => Post);
            }
        }
        public String PostAsJson
        {
            set
            {
                _postAsJson = value;
                Post = JsonConvert.DeserializeObject<Post>(_postAsJson);
            }
            get { return _postAsJson; }
        }
        #endregion

        public BlogPostDetailsViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}

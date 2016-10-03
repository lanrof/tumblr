using System;
using System.Windows;
using System.Windows.Controls;
using Tumblr.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Tumblr.WP
{
    public partial class SinglePostUserControl : UserControl, INotifyPropertyChanged
    {
        #region fields
        private bool _isPhotoPostVisible;
        private bool _isRegularPostVisible;
        private bool _isQuotePostVisible;
        private bool _isVideoPostVisible;
        private bool _isLinkPostVisible;
        private bool _isAudioPostVisible;
        private bool _isCharPostVisible;
        private string _title;
        private string _contentText;
        private string _photoCaption;
        private string _photoUri;
        private string _quote;
        private string _quoteSource;
        private string _linkTitle;
        private string _linkUrl;
        private string _videoCaption;
        private string _videoSource;
        private string _videoIFramePlayer;
        private string _audioTitle;
        private string _audioCaption;
        private string _audioIFramePlayer;
        private string _audioArtist;
        private string _audioPlaysCount;
        private string _conversationTitle;
        private string _conversationText;
        private ObservableCollection<Conversation> _conversation;
        #endregion

        #region properties
        public bool IsPhotoPostVisible
        {
            get { return _isPhotoPostVisible; }
            set
            {
                _isPhotoPostVisible = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool IsRegularPostVisible
        {
            get { return _isRegularPostVisible; }
            set
            {
                _isRegularPostVisible = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool IsQuotePostVisible
        {
            get { return _isQuotePostVisible; }
            set
            {
                _isQuotePostVisible = value;
                NotifyPropertyChanged();
            }
        }    
        
        public bool IsLinkPostVisible
        {
            get { return _isLinkPostVisible; }
            set
            {
                _isLinkPostVisible = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool IsVideoPostVisible
        {
            get { return _isVideoPostVisible; }
            set
            {
                _isVideoPostVisible = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool IsAudioPostVisible
        {
            get { return _isAudioPostVisible; }
            set
            {
                _isAudioPostVisible = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool IsChatPostVisible
        {
            get { return _isCharPostVisible; }
            set
            {
                _isCharPostVisible = value;
                NotifyPropertyChanged();
            }
        }
        
        public string Title
        {
            get { return _title; }
            set
            {
                if (Equals(value, _title))
                {
                    return;
                }
                _title = value;
                NotifyPropertyChanged();
            }
        }
        
        public string ContentText
        {
            get { return _contentText; }
            set
            {
                if (Equals(value, _contentText))
                {
                    return;
                }
                _contentText = value;
                NotifyPropertyChanged();
            }
        }

        public string PhotoCaption
        {
            get { return _photoCaption; }
            set
            {
                if (Equals(value, _photoCaption))
                {
                    return;
                }
                _photoCaption = value;
                NotifyPropertyChanged();
            }
        }
        
        public string PhotoUri
        {
            get { return _photoUri; }
            set
            {
                if (Equals(value, _photoUri))
                {
                    return;
                }
                _photoUri = value;
                NotifyPropertyChanged();
            }
        }
        
        public string Quote
        {
            get { return _quote; }
            set
            {
                if (Equals(value, _quote))
                {
                    return;
                }
                _quote = value;
                NotifyPropertyChanged();
            }
        }
        
        public string QuoteSource
        {
            get { return _quoteSource; }
            set
            {
                if (Equals(value, _quoteSource))
                {
                    return;
                }
                _quoteSource = value;
                NotifyPropertyChanged();
            }
        }
        
        public string LinkTitle
        {
            get { return _linkTitle; }
            set
            {
                if (Equals(value, _linkTitle))
                {
                    return;
                }
                _linkTitle = value;
                NotifyPropertyChanged();
            }
        }
        
        public string LinkUrl
        {
            get { return _linkUrl; }
            set
            {
                if (Equals(value, _linkUrl))
                {
                    return;
                }
                _linkUrl = value;
                NotifyPropertyChanged();
            }
        }
        
        public string VideoCaption
        {
            get { return _videoCaption; }
            set
            {
                if (Equals(value, _videoCaption))
                {
                    return;
                }
                _videoCaption = value;
                NotifyPropertyChanged();
            }
        }
        
        public string VideoSource
        {
            get { return _videoSource; }
            set
            {
                if (Equals(value, _videoSource))
                {
                    return;
                }
                _videoSource = value;
                NotifyPropertyChanged();
            }
        }
        
        public string VideoIFramePlayer
        {
            get { return _videoIFramePlayer; }
            set
            {
                if (Equals(value, _videoIFramePlayer))
                {
                    return;
                }
                _videoIFramePlayer = value;
                NotifyPropertyChanged();
            }
        }
        
        public string AudioTitle
        {
            get { return _audioTitle; }
            set
            {
                if (Equals(value, _audioTitle))
                {
                    return;
                }
                _audioTitle = value;
                NotifyPropertyChanged();
            }
        }
        
        public string AudioCaption
        {
            get { return _audioCaption; }
            set
            {
                if (Equals(value, _audioCaption))
                {
                    return;
                }
                _audioCaption = value;
                NotifyPropertyChanged();
            }
        }

        public string AudioIFramePlayer
        {
            get { return _audioIFramePlayer; }
            set
            {
                if (Equals(value, _audioIFramePlayer))
                {
                    return;
                }
                _audioIFramePlayer = value;
                NotifyPropertyChanged();
            }
        }
        
        public string AudioArtist
        {
            get { return _audioArtist; }
            set
            {
                if (Equals(value, _audioArtist))
                {
                    return;
                }
                _audioArtist = value;
                NotifyPropertyChanged();
            }
        }
       
        public string AudioPlaysCount
        {
            get { return _audioPlaysCount; }
            set
            {
                if (Equals(value, _audioPlaysCount))
                {
                    return;
                }
                _audioPlaysCount = value;
                NotifyPropertyChanged();
            }
        }
        
        public string ConversationTitle
        {
            get { return _conversationTitle; }
            set
            {
                if (Equals(value, _conversationTitle))
                {
                    return;
                }
                _conversationTitle = value;
                NotifyPropertyChanged();
            }
        }
        
        public string ConversationText
        {
            get { return _conversationText; }
            set
            {
                if (Equals(value, _conversationText))
                {
                    return;
                }
                _conversationText = value;
                NotifyPropertyChanged();
            }
        }
        
        public ObservableCollection<Conversation> Conversation
        {
            get { return _conversation; }
            set
            {
                if (Equals(value, _conversation))
                {
                    return;
                }
                _conversation = value;
                NotifyPropertyChanged();
            }
        }

        public string PostTypeLabel
        {
            get
            {
                if (Post != null && !String.IsNullOrEmpty(Post.Type)) return "Post type : " + Post.Type;
                else return "";
            }
        }

        public string TagLabel
        {
            get
            {
                if(Post != null && Post.Tags != null)
                {
                    var label = "Tags :";
                    foreach(var t in Post.Tags)
                    {
                        label += "   " + t;
                    }
                    return label;
                }
                return "";
            }
        }

        public Post Post
        {
            get { return (Post)GetValue(PostProperty); }
            set { SetValue(PostProperty, value); }
        }
        #endregion

        public static readonly DependencyProperty PostProperty =
            DependencyProperty.Register("Post", typeof(Post),
                typeof(SinglePostUserControl), new PropertyMetadata(default(Post), OnPostChanged));
        private static void OnPostChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var singlePostUserControl = sender as SinglePostUserControl;
            if (singlePostUserControl != null)
            {
                singlePostUserControl.PostChanged();
            }
        }

        public SinglePostUserControl()
        {
            InitializeComponent();
            Conversation = new ObservableCollection<Conversation>();
        }    

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region methods
        public void PostChanged()
        {
            IsRegularPostVisible = false;
            IsPhotoPostVisible = false;
            IsQuotePostVisible = false;
            IsLinkPostVisible = false;
            IsVideoPostVisible = false;
            IsAudioPostVisible = false;
            IsChatPostVisible = false;

            if (Post.Type == "regular")
            {
                Title = Post.RegularTitle;
                ContentText = Post.RegularBody;
                IsRegularPostVisible = true;
            }
            else if(Post.Type == "quote")
            {
                Quote = Post.QuoteText;
                QuoteSource = Post.QuoteSource;
                IsQuotePostVisible = true;
            }
            else if(Post.Type == "photo")
            {                
                PhotoCaption = Post.PhotoCaption;
                PhotoUri = Post.PhotoUrl_400;
                IsPhotoPostVisible = true;
            }
            else if (Post.Type == "link")
            {
                LinkTitle = Post.LinkText;
                LinkUrl = Post.LinkUrl;
                IsLinkPostVisible = true;
            }
            else if (Post.Type == "video")
            {
                VideoCaption = Post.VideoCaption;
                VideoSource = Post.VideoSource;
                VideoIFramePlayer = Post.VideoPlayer;
                IsVideoPostVisible = true;
            }
            else if (Post.Type == "audio")
            {
                AudioTitle = "Title : " + Post.AudioTitle;
                AudioArtist = "Artist : " + Post.AudioArtist;
                AudioCaption = Post.AudioCaption;
                AudioIFramePlayer = Post.AudioPlayer;
                AudioPlaysCount = "Audio plays : " + Post.AudioPlaysCount;
                IsAudioPostVisible = true;
            }
            else if (Post.Type == "conversation")
            {
                ConversationTitle = Post.ConversationTitle;
                ConversationText = Post.ConversationText;
                Conversation = new ObservableCollection<Conversation>(Post.Conversation);
                IsChatPostVisible = true;
            }
            else
            {
                IsRegularPostVisible = true;                
                Title = "Post type : " + Post.Type + " not supported";
            }

            NotifyPropertyChanged(nameof(PostTypeLabel));
            NotifyPropertyChanged(nameof(TagLabel));
        }

        public void OpenLink()
        {
            ShowInBrowser(LinkUrl);
        }

        public void OpenVideoLink()
        {
            ShowInBrowser(VideoSource);
        }
        
        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            try
            {
                wbt.Uri = new Uri(url);
                wbt.Show();
            }
            catch { }
        }
        #endregion
    }
}

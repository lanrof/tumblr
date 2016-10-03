using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tumblr.Model
{
    public partial class Post
    {
        //photo
        [JsonProperty(PropertyName = "photo-caption")]
        public string PhotoCaption { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        [JsonProperty(PropertyName = "photo-url-1280")]
        public string PhotoUrl_1280 { get; set; }
        [JsonProperty(PropertyName = "photo-url-500")]
        public string PhotoUrl_500 { get; set; }
        [JsonProperty(PropertyName = "photo-url-400")]
        public string PhotoUrl_400 { get; set; }
        [JsonProperty(PropertyName = "photo-url-250")]
        public string PhotoUrl_250 { get; set; }
        [JsonProperty(PropertyName = "photo-url-100")]
        public string PhotoUrl_100 { get; set; }
        [JsonProperty(PropertyName = "photo-url-75")]
        public string PhotoUrl_75 { get; set; }
        public List<object> Photos { get; set; }
    }
}

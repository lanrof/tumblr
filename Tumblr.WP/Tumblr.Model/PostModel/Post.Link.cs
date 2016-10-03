using Newtonsoft.Json;

namespace Tumblr.Model
{
    public partial class Post
    {
        //link
        [JsonProperty(PropertyName = "link-url")]
        public string LinkUrl { get; set; }
        [JsonProperty(PropertyName = "link-description")]
        public string LinkDescription { get; set; }
        [JsonProperty(PropertyName = "link-text")]
        public string LinkText { get; set; }
    }
}

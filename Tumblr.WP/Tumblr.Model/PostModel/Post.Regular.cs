using Newtonsoft.Json;

namespace Tumblr.Model
{
    public partial class Post
    {
        //regular (text)
        [JsonProperty(PropertyName = "regular-title")]
        public string RegularTitle { get; set; }
        [JsonProperty(PropertyName = "regular-body")]
        public string RegularBody { get; set; }
    }
}

using Newtonsoft.Json;

namespace Tumblr.Model
{
    public partial class Post
    {
        //video
        [JsonProperty(PropertyName = "video-caption")]
        public string VideoCaption { get; set; }
        [JsonProperty(PropertyName = "video-source")]
        public string VideoSource { get; set; }
        [JsonProperty(PropertyName = "video-player")]
        public string VideoPlayer { get; set; }
        [JsonProperty(PropertyName = "video-player-500")]
        public string VideoPlayer_500 { get; set; }
        [JsonProperty(PropertyName = "video-player-250")]
        public string VideoPlayer_250 { get; set; }
    }
}

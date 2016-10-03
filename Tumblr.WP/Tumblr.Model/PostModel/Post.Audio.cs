using Newtonsoft.Json;

namespace Tumblr.Model
{
    public partial class Post
    {
        //audio
        [JsonProperty(PropertyName = "id3-artist")]
        public string AudioArtist { get; set; }
        [JsonProperty(PropertyName = "id3-title")]
        public string AudioTitle { get; set; }
        [JsonProperty(PropertyName = "audio-caption")]
        public string AudioCaption { get; set; }
        [JsonProperty(PropertyName = "audio-player")]
        public string AudioPlayer { get; set; }
        [JsonProperty(PropertyName = "audio-plays")]
        public int AudioPlaysCount { get; set; }
    }
}

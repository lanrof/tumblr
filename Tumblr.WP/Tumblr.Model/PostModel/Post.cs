using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tumblr.Model
{
    public partial class Post
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        [JsonProperty(PropertyName = "unix-timestamp")]
        public int UnixTimestamp { get; set; }
        public string Slug { get; set; }
        public List<string> Tags { get; set; }
    }
}

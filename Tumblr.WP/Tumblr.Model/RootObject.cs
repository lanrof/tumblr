using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tumblr.Model
{
    public class RootObject
    {
        public Tumblelog Tumblelog { get; set; }
        [JsonProperty(PropertyName = "posts-start")]
        public int PostsStart { get; set; }
        [JsonProperty(PropertyName = "posts-total")]
        public int PostsTotal { get; set; }
        [JsonProperty(PropertyName = "posts-type")]
        public string PostsType { get; set; }
        public List<Post> Posts { get; set; }
    }
}

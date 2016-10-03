using Newtonsoft.Json;

namespace Tumblr.Model
{
    public partial class Post
    {
        //quote
        [JsonProperty(PropertyName = "quote-text")]
        public string QuoteText { get; set; }
        [JsonProperty(PropertyName = "quote-source")]
        public string QuoteSource { get; set; }
    }
}

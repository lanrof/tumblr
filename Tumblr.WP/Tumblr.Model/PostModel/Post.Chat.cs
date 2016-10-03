using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tumblr.Model
{
    public partial class Post
    {
        //chat
        [JsonProperty(PropertyName = "conversation-title")]
        public string ConversationTitle { get; set; }
        [JsonProperty(PropertyName = "conversation-text")]
        public string ConversationText { get; set; }
        public List<Conversation> Conversation { get; set; }
    }
}

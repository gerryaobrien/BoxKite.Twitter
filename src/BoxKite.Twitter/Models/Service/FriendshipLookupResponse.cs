﻿// (c) 2012-2013 Nick Hodge mailto:hodgenick@gmail.com & Brendan Forster
// License: MS-PL
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BoxKite.Twitter.Models.Service
{
    public class FriendshipLookupResponse : TwitterControlBase 
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("connections")]
        public IEnumerable<string> Connections { get; set; }
    }
}

﻿// (c) 2012-2013 Nick Hodge mailto:hodgenick@gmail.com & Brendan Forster
// License: MS-PL
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BoxKite.Twitter.Models.Service
{

    public class SuggestedUsers : TwitterControlBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("users")]
        public IEnumerable<User> Users { get; set; }
    }

}

﻿using Newtonsoft.Json;

namespace CSharpOsu.V1.MultiPlayer
{
    public class OsuMatch
    {
        [JsonProperty("match")]
        public OsuMatchMetadata Match { get; set; }

        [JsonProperty("games")]
        public OsuMatchGame[] Games { get; set; }
    }
}
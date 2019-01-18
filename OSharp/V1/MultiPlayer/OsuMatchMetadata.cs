﻿using System;
using Newtonsoft.Json;
using OSharp.V1.Internal;

namespace OSharp.V1.MultiPlayer
{
    public class OsuMatchMetadata
    {
        [JsonProperty("match_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MatchId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTimeOffset? EndTime { get; set; }
    }
}
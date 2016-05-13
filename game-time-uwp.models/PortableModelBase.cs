using System;
using Newtonsoft.Json;

namespace game_time_uwp.models
{
    public abstract class PortableModelBase
    {
        public DateTimeOffset? CreatedAt { get; set; }

        public bool Deleted { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public byte[] Version { get; set; }
    }
}

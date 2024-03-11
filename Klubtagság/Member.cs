using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Klubtagság
{

    public partial class Member
    {
       

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("entry")]
        public String Entry { get; set; } 

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("interest")]
        public string Interest { get; set; }
        
       

        public override string? ToString()
        {
            return Fullname;
        }
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    public partial class Member
    {
        public static Member[] FromJson(string json) => JsonConvert.DeserializeObject<Member[]>(json, Converter.Settings);
    }
}

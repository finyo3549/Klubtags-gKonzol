using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Klubtagság
{

    internal class Member
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("entry")]
        public string EntryString { get; set; } 

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("interest")]
        public string Interest { get; set; }
        public DateTime Entry
        {
            get
            {
                DateTime.TryParse(EntryString, out DateTime entryDate);
                return entryDate;
            }
        }
    }
}

using RestWithASPNETUdemy.HypermediaFilterOptions;
using RestWithASPNETUdemy.HypermediaFilterOptions.Abstract;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO: ISupportsHyperMedia
    {
        [JsonPropertyName("code")]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

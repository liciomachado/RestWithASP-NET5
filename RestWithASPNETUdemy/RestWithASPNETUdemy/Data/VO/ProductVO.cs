using RestWithASPNETUdemy.HypermediaFilterOptions;
using RestWithASPNETUdemy.HypermediaFilterOptions.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Model
{
    public class ProductVO: ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Item { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}

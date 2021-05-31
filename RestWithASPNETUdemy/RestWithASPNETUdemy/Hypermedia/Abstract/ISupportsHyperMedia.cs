using System.Collections.Generic;

namespace RestWithASPNETUdemy.HypermediaFilterOptions.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}

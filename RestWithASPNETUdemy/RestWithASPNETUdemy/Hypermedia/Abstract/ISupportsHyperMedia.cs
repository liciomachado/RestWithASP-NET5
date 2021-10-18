using System.Collections.Generic;

namespace RestCrudApi.HypermediaFilterOptions.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}

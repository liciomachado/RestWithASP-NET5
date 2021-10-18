using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace RestCrudApi.HypermediaFilterOptions.Abstract
{
    public interface IResponseEnricher
    {
        public bool CanEnrich(ResultExecutingContext context);

        Task Enrich(ResultExecutingContext context);
    }
}

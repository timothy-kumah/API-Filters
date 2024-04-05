using Microsoft.AspNetCore.Mvc.Filters;

namespace API_Filters.Configurations.Filters
{
    public class MyFilters : IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Filter now executing");
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }


    }
}

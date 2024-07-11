using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Doppler.AspNetCore.HypermediaApi.Metadata;
using Doppler.AspNetCore.HypermediaApi.ExceptionHandling;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Doppler.AspNetCore.HypermediaApi.SuitableValidators
{
	public class SuitableValidationFilter : IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
			var actionAttribute = actionDescriptor?.MethodInfo.GetCustomAttribute<ActionRelationAttribute>(true);

			if (actionAttribute != null)
			{
				var problem = await actionAttribute.ExecuteSuitableValidationsAsync(context.HttpContext.RequestServices, context.ActionArguments);

				if (problem.HasValue)
				{
					throw new ApiException(problem.Value);
				}
			}

			await next();
		}
	}
}

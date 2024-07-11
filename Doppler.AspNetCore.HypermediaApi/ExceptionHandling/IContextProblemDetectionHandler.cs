using Doppler.AspNetCore.Abstractions;
using Microsoft.AspNetCore.Http;
using System;

namespace Doppler.AspNetCore.HypermediaApi.ExceptionHandling
{
	public interface IContextProblemDetectionHandler
	{
		Maybe<Problem> CheckForProblem(HttpContext context);
	}
}

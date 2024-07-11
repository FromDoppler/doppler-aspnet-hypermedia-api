using Doppler.AspNetCore.HypermediaApi.ExceptionHandling;
using Microsoft.AspNetCore.Http;

namespace Doppler.AspNetCore.HypermediaApi.Problems
{
	public class RouteNotFoundProblem : NotFoundProblem
	{
		public override string title => "Route Not Found";
		public override string detail => $"Route not found resolving `{resourceNotFoundPath}`";
		public override int status => StatusCodes.Status404NotFound;
		public override int errorCode => 0;
	}
}

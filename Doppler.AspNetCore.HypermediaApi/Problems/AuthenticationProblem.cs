using Doppler.AspNetCore.HypermediaApi.ExceptionHandling;
using Microsoft.AspNetCore.Http;

namespace Doppler.AspNetCore.HypermediaApi.Problems
{
	public abstract class AuthenticationProblem : Problem
	{
		public override int status => StatusCodes.Status401Unauthorized;

		public AuthenticationProblem()
		{
			AddHeader("WWW-Authenticate", "Bearer");
		}
	}
}

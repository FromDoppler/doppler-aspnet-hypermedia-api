using Doppler.AspNetCore.Abstractions;
using System;

namespace Doppler.AspNetCore.HypermediaApi.ExceptionHandling
{
	public interface IExceptionProblemDetectionHandler
	{
		Problem ExtractProblem(Exception exception);
	}
}

﻿using System;

namespace Doppler.AspNetCore.HypermediaApi.ExceptionHandling
{
	public class ApiException : Exception
	{
		public Problem Problem { get; set; }

		public ApiException(Problem problem)
		{
			Problem = problem;
		}
	}
}

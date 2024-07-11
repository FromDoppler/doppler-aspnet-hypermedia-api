using System;
using System.Text;

namespace Doppler.AspNetCore.Authentication.Abstractions
{
	public class AuthenticationException : Exception
	{
		public AuthenticationException(string message)
			: base(message)
		{

		}
	}
}

using System.Collections.Generic;
using Doppler.AspNetCore.HypermediaApi.ExceptionHandling;
using Doppler.AspNetCore.HypermediaApi.Linking;
using System.Threading.Tasks;
using Doppler.AspNetCore.Abstractions;

namespace Doppler.AspNetCore.HypermediaApi.SuitableValidators
{
	public interface ISuitableValidator
	{
		Task<Maybe<Problem>> ValidateAsync(IDictionary<string, TemplateParameter> values);
	}
}

using System.Collections.Generic;

namespace Doppler.AspNetCore.HypermediaApi.Model
{
	public interface IModelCollection
	{
	}

	public interface IModelCollection<T> : IModelCollection
	{
		List<T> items { get; }
	}
}

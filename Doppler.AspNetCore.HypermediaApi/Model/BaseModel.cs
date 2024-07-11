using Doppler.AspNetCore.HypermediaApi.Linking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Doppler.AspNetCore.HypermediaApi.Model
{
	public abstract class BaseModel
	{
		//TODO: mark as readonly
		[JsonProperty(PropertyName = "_links", NullValueHandling = NullValueHandling.Ignore)]
		public LinkCollection _links { get; } = new LinkCollection();
	}
}

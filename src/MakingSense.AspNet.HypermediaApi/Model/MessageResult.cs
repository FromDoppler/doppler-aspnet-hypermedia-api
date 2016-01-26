﻿using MakingSense.AspNet.HypermediaApi.Metadata;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace MakingSense.AspNet.HypermediaApi.Model
{
	//TODO support [Schema] (without parameter)
	[Schema(typeof(MessageResult))]
	public class MessageResult : BaseModel
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore, Required = Required.Always)]
		[Required]
		public string message { get; set; } = string.Empty;
	}
}

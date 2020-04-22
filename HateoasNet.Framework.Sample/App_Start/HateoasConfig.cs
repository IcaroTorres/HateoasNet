﻿using System;
using HateoasNet.Abstractions;

namespace HateoasNet.Framework.Sample
{
	public static class HateoasConfig
	{
		public static IHateoasContext MapFromAssembly(IHateoasContext config, Type containedInAssembly)
		{
			// Hateoas map configuration using IHateoasBuilders from assembly
			return config.ApplyConfigurationsFromAssembly(containedInAssembly.Assembly);
		}
	}
}
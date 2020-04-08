﻿namespace HateoasNet.Resources
{
	public class ResourceLink
	{
		public ResourceLink(string rel, string href, string method)
		{
			Rel = rel;
			Href = href;
			Method = method;
		}

		public string Href { get; }
		public string Rel { get; }
		public string Method { get; }
	}
}
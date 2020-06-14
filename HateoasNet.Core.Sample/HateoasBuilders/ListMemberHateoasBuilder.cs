﻿using System.Collections.Generic;
using HateoasNet.Abstractions;
using HateoasNet.Core.Sample.Models;

namespace HateoasNet.Core.Sample.HateoasBuilders
{
	public class ListMemberHateoasBuilder : IHateoasSourceBuilder<List<Member>>
	{
		public void Build(IHateoasSource<List<Member>> resource)
		{
			resource.AddLink("get-members");
			resource.AddLink("invite-member");
			resource.AddLink("create-member");
		}
	}
}
﻿using HateoasNet.Abstractions;
using HateoasNet.Core.Sample.Models;
using System.Collections.Generic;

namespace HateoasNet.Core.Sample.HateoasConfigurations
{
    public class ListMemberHateoasConfiguration : IHateoasResourceConfiguration<List<Member>>
    {
        public void Configure(IHateoasResource<List<Member>> resource)
        {
            resource.HasLink("get-members");
            resource.HasLink("invite-member");
            resource.HasLink("create-member");
        }
    }
}
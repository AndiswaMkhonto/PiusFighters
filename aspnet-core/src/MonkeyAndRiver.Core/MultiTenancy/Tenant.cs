﻿using Abp.MultiTenancy;
using MonkeyAndRiver.Authorization.Users;

namespace MonkeyAndRiver.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

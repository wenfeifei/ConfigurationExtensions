﻿using System;
using Microsoft.Extensions.Configuration;

namespace Yt.Extensions.Configuration.Properties
{
    public class PropertiesConfigurationSource : FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new PropertiesConfigurationProvider(this);
        }
    }
}

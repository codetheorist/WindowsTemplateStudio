﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WtsTool
{
    public enum EnvEnum
    {
        Pro,
        Pre,
        Dev,
        Test,
        Unknown
    }

    public static class Environments
    {
        public static Dictionary<EnvEnum, string> CdnUrls => new Dictionary<EnvEnum, string>()
        {
            { EnvEnum.Test, "https://wtsrepository.blob.core.windows.net/test" },
            { EnvEnum.Dev, "https://wtsrepository.blob.core.windows.net/dev" },
            { EnvEnum.Pre, "https://wtsrepository.blob.core.windows.net/pre" },
            { EnvEnum.Dev, "https://wts2.azureedge.net" }
        };
    }
}

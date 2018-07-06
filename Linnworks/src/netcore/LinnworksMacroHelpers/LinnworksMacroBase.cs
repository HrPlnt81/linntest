﻿using LinnworksMacroHelpers.Classes;
using LinnworksMacroHelpers.Interfaces;

namespace LinnworksMacroHelpers
{
    public class LinnworksMacroBase
    {
        public IRuntimeHelper RunTime { get; set; }
        public LinnworksAPI.ApiObjectManager Api { get; set; }
        public IProxyFactory ProxyFactory { get; set; }
        public ILogger Logger { get; set; }
        public MacroConfigurationProxy Configuration { get; set; }
    }
}

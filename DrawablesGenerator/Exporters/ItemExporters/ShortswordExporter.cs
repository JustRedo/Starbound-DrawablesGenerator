﻿using Newtonsoft.Json.Linq;
using Silverfeelin.StarboundDrawables;

namespace DrawablesGeneratorTool
{
    public class ShortswordExporter : Exporter, IExporter
    {
        public override string Template
        {
            get
            {
                return Properties.Resources.Sword;
            }
        }

        public ShortswordExporter(DrawablesOutput output) : base(output)
        {
        }
    }
}

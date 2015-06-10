﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxHttp
{

    public sealed class Location : LightCollection
    {
        public Location(LifxClient client, string id, string label, List<Light> lights)
            : base(client, id, label, lights) { }

        public static implicit operator Selector(Location location)
        {
            return new Selector.LocationId(location.Id);
        }
    }
}

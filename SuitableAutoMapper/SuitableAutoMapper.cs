using System;
using System.Linq;
using System.Collections.Generic;

namespace SuitableAutoMapper
{
    class SuitableMapper
    {
        public SuitableMapper()
        {

        }
        public void Map<T1, T2>(T1 src, T2 dest)
        {
            var srcProperies = typeof(T1).GetProperties();
            var destProperies = typeof(T2).GetProperties();

            foreach (var property in destProperies)
            {
                var destproperty = srcProperies.Where(
                    (s => s.Name == property.Name && s.GetMethod.ReturnType == property.GetMethod.ReturnType))
                    .SingleOrDefault();
                if (destproperty != null)
                    property.SetValue(dest, destproperty.GetValue(src));
            }
        }
    }
}

#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_double4 : AppaList<double4>
    {
        public AppaList_double4()
        {
        }

        public AppaList_double4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_double4(AppaList<double4> list) : base(list)
        {
        }

        public AppaList_double4(double4[] values) : base(values)
        {
        }
    }
}

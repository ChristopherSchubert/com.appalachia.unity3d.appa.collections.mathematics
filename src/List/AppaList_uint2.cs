#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_uint2 : AppaList<uint2>
    {
        public AppaList_uint2()
        {
        }

        public AppaList_uint2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_uint2(AppaList<uint2> list) : base(list)
        {
        }

        public AppaList_uint2(uint2[] values) : base(values)
        {
        }
    }
}

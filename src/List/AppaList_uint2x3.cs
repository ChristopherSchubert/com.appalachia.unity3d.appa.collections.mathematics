#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_uint2x3 : AppaList<uint2x3>
    {
        public AppaList_uint2x3()
        {
        }

        public AppaList_uint2x3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_uint2x3(AppaList<uint2x3> list) : base(list)
        {
        }

        public AppaList_uint2x3(uint2x3[] values) : base(values)
        {
        }
    }
}

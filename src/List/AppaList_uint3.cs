#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_uint3 : AppaList<uint3>
    {
        public AppaList_uint3()
        {
        }

        public AppaList_uint3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_uint3(AppaList<uint3> list) : base(list)
        {
        }

        public AppaList_uint3(uint3[] values) : base(values)
        {
        }
    }
}

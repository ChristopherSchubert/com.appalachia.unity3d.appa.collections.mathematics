#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_uint4 : AppaList<uint4>
    {
        public AppaList_uint4()
        {
        }

        public AppaList_uint4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_uint4(AppaList<uint4> list) : base(list)
        {
        }

        public AppaList_uint4(uint4[] values) : base(values)
        {
        }
    }
}

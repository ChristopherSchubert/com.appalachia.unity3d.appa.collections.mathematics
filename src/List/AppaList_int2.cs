#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_int2 : AppaList<int2>
    {
        public AppaList_int2()
        {
        }

        public AppaList_int2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_int2(AppaList<int2> list) : base(list)
        {
        }

        public AppaList_int2(int2[] values) : base(values)
        {
        }
    }
}

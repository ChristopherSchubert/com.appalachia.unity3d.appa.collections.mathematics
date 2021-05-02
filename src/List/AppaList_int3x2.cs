#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_int3x2 : AppaList<int3x2>
    {
        public AppaList_int3x2()
        {
        }

        public AppaList_int3x2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_int3x2(AppaList<int3x2> list) : base(list)
        {
        }

        public AppaList_int3x2(int3x2[] values) : base(values)
        {
        }
    }
}

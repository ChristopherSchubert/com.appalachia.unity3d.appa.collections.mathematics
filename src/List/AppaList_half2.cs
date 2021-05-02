#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_half2 : AppaList<half2>
    {
        public AppaList_half2()
        {
        }

        public AppaList_half2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_half2(AppaList<half2> list) : base(list)
        {
        }

        public AppaList_half2(half2[] values) : base(values)
        {
        }
    }
}

#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_half : AppaList<half>
    {
        public AppaList_half()
        {
        }

        public AppaList_half(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_half(AppaList<half> list) : base(list)
        {
        }

        public AppaList_half(half[] values) : base(values)
        {
        }
    }
}

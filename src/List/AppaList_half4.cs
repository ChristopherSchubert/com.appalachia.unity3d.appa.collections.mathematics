#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_half4 : AppaList<half4>
    {
        public AppaList_half4()
        {
        }

        public AppaList_half4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_half4(AppaList<half4> list) : base(list)
        {
        }

        public AppaList_half4(half4[] values) : base(values)
        {
        }
    }
}

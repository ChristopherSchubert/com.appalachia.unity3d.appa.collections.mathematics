#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_int4x4 : AppaList<int4x4>
    {
        public AppaList_int4x4()
        {
        }

        public AppaList_int4x4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_int4x4(AppaList<int4x4> list) : base(list)
        {
        }

        public AppaList_int4x4(int4x4[] values) : base(values)
        {
        }
    }
}

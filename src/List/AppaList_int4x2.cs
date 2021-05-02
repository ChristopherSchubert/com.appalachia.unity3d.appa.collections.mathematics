#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_int4x2 : AppaList<int4x2>
    {
        public AppaList_int4x2()
        {
        }

        public AppaList_int4x2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_int4x2(AppaList<int4x2> list) : base(list)
        {
        }

        public AppaList_int4x2(int4x2[] values) : base(values)
        {
        }
    }
}

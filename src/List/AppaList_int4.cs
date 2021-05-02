#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_int4 : AppaList<int4>
    {
        public AppaList_int4()
        {
        }

        public AppaList_int4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_int4(AppaList<int4> list) : base(list)
        {
        }

        public AppaList_int4(int4[] values) : base(values)
        {
        }
    }
}

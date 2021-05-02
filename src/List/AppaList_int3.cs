#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_int3 : AppaList<int3>
    {
        public AppaList_int3()
        {
        }

        public AppaList_int3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_int3(AppaList<int3> list) : base(list)
        {
        }

        public AppaList_int3(int3[] values) : base(values)
        {
        }
    }
}

#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_bool2 : AppaList<bool2>
    {
        public AppaList_bool2()
        {
        }

        public AppaList_bool2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_bool2(AppaList<bool2> list) : base(list)
        {
        }

        public AppaList_bool2(bool2[] values) : base(values)
        {
        }
    }
}

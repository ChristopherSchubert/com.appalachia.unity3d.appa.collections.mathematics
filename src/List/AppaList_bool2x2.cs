#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_bool2x2 : AppaList<bool2x2>
    {
        public AppaList_bool2x2()
        {
        }

        public AppaList_bool2x2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_bool2x2(AppaList<bool2x2> list) : base(list)
        {
        }

        public AppaList_bool2x2(bool2x2[] values) : base(values)
        {
        }
    }
}

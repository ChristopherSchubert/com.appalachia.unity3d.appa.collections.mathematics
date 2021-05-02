#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_bool3x2 : AppaList<bool3x2>
    {
        public AppaList_bool3x2()
        {
        }

        public AppaList_bool3x2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_bool3x2(AppaList<bool3x2> list) : base(list)
        {
        }

        public AppaList_bool3x2(bool3x2[] values) : base(values)
        {
        }
    }
}

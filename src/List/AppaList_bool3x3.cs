#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_bool3x3 : AppaList<bool3x3>
    {
        public AppaList_bool3x3()
        {
        }

        public AppaList_bool3x3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_bool3x3(AppaList<bool3x3> list) : base(list)
        {
        }

        public AppaList_bool3x3(bool3x3[] values) : base(values)
        {
        }
    }
}

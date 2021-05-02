#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_bool3 : AppaList<bool3>
    {
        public AppaList_bool3()
        {
        }

        public AppaList_bool3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_bool3(AppaList<bool3> list) : base(list)
        {
        }

        public AppaList_bool3(bool3[] values) : base(values)
        {
        }
    }
}

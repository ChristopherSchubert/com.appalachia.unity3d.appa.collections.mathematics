#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_bool4x3 : AppaList<bool4x3>
    {
        public AppaList_bool4x3()
        {
        }

        public AppaList_bool4x3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_bool4x3(AppaList<bool4x3> list) : base(list)
        {
        }

        public AppaList_bool4x3(bool4x3[] values) : base(values)
        {
        }
    }
}

#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_double2x2 : AppaList<double2x2>
    {
        public AppaList_double2x2()
        {
        }

        public AppaList_double2x2(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_double2x2(AppaList<double2x2> list) : base(list)
        {
        }

        public AppaList_double2x2(double2x2[] values) : base(values)
        {
        }
    }
}

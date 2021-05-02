#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_float3x3 : AppaList<float3x3>
    {
        public AppaList_float3x3()
        {
        }

        public AppaList_float3x3(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_float3x3(AppaList<float3x3> list) : base(list)
        {
        }

        public AppaList_float3x3(float3x3[] values) : base(values)
        {
        }
    }
}

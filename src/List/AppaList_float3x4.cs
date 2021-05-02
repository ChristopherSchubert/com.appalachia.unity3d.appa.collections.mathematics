#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_float3x4 : AppaList<float3x4>
    {
        public AppaList_float3x4()
        {
        }

        public AppaList_float3x4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_float3x4(AppaList<float3x4> list) : base(list)
        {
        }

        public AppaList_float3x4(float3x4[] values) : base(values)
        {
        }
    }
}

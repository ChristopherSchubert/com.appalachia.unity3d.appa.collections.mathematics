#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_float4x4 : AppaList<float4x4>
    {
        public AppaList_float4x4()
        {
        }

        public AppaList_float4x4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_float4x4(AppaList<float4x4> list) : base(list)
        {
        }

        public AppaList_float4x4(float4x4[] values) : base(values)
        {
        }
    }
}

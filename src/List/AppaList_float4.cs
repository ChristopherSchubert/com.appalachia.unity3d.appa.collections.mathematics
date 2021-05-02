#region

using System;
using collections.src;

#endregion

namespace collections.mathematics.src.List
{
    [Serializable]
    public sealed class AppaList_float4 : AppaList<float4>
    {
        public AppaList_float4()
        {
        }

        public AppaList_float4(int capacity, float capacityIncreaseMultiplier = 2, bool noTracking = false) : base(
            capacity,
            capacityIncreaseMultiplier,
            noTracking
        )
        {
        }

        public AppaList_float4(AppaList<float4> list) : base(list)
        {
        }

        public AppaList_float4(float4[] values) : base(values)
        {
        }
    }
}

using System.Runtime.CompilerServices;
using EncosyTower.Ids;
using EncosyTower.Types;

namespace EncosyTower.PresetIds
{
    public readonly record struct PresetId(Id Value)
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
            => Value.ToString();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PresetId(Id value)
            => new(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PresetId(Id.Serializable value)
            => new(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Id(PresetId value)
            => value.Value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Id.Serializable(PresetId value)
            => value.Value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Id2(PresetId value)
            => Type<PresetId>.Id.ToId2(value);
    }
}

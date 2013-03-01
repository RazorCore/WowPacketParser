using System;

namespace WowPacketParser.Enums
{
    [Flags]
    public enum MovementFlagExtra : ushort // 5.1.0
    {
        None = 0x0000,
        PreventStrafe = 0x0001,
        PreventJumping = 0x0002,
        DisableCollision = 0x0004,
        FullSpeedTurning = 0x0008,
        FullSpeedPitching = 0x0010,
        AlwaysAllowPitching = 0x0020,
        IsVehicleExitVoluntary = 0x0040,
        IsJumpSplineInAir = 0x0080,
        IsAnimTierInTrans = 0x0100,
        PreventChangePitch = 0x0200,
        InterpolateMove = 0x0400,
        InterpolateTurning = 0x0800,
        InterpolatePitching = 0x1000,
        VehiclePassengerIsTransitionAllowed = 0x2000,
        CanTransitionBetweenSwimAndFly = 0x4000,
    }
}

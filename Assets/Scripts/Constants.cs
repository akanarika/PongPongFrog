using UnityEngine;
using System.Collections;

public static class Constants {

    public const float JumpDistance = 150.0f;
    public const float DistanceError = 1f;
    public const float JumpSpeed = 50f;
    public const float AirTime = 1f;
    public const float LilypadSize = 2.5f;
    public const float LilypadDistance = 12f;
    public const float GameBoundary = 45f;
    public const float PadDistance = 7f;
    public const int trapSteps = 10;
    public const float DownTime = 0.25f;
    public const float DropletMinCooldown = 15f;//2f;
    public const float DropletMaxCooldown = 25f;//15f
    public const float PowerMinCooldown = 5f;//10f;
    public const float PowerMaxCooldown = 15f;//20f;
    public const float enlargeTextSize = 2.0f;
    public const float lilypadMinLife = 15f;
    public const float lilypadMaxLife = 30f;

    public const float ActiveTime = 4f;
    public const float GameLength = 4f;


    public static class Layers
    {
        public const int Frog = 8;
        public const float FrogHeight = 0.5f;
        public const int Lilypad = 9;
        public const float LilypadHeight = 0.15f;
        public const int LandingZone = 10;
        public const int Background = 11;
        public const float BackgroundHeight = 0f;
        public const int StandingZone = 12;

        public static float getHeight(int layer) {
            switch(layer) {
                case Frog:
                    return FrogHeight;
                case Lilypad:
                    return LilypadHeight;
                case Background:
                default:
                    return BackgroundHeight;
            }
        }

    }

}

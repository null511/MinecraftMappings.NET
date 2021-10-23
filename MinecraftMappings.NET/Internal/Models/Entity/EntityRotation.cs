using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityRotation
    {
        public string Name;
        public Vector3 Translation;
        public float RotationAngleX;
        public float RotationAngleY;
        public float RotationAngleZ;
        public bool Rescale;
        //public float Inflate;
        public bool InvertAxisX;
        public bool InvertAxisY;
        public bool InvertAxisZ;

        public List<EntityElement> Elements {get; set;}
        public List<EntityRotation> Rotations {get; set;}

        public bool HasRotation => RotationAngleX != 0 || RotationAngleY != 0 || RotationAngleZ != 0;
    }
}

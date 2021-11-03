using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityElement
    {
        public string Name;
        public Vector3 Translate;
        public float RotationAngleX;
        public float RotationAngleY;
        public float RotationAngleZ;
        public bool Rescale;
        public bool InvertAxisX;
        public bool InvertAxisY;
        public bool InvertAxisZ;
        public bool MirrorTexU;
        //public bool MirrorTexV;

        public List<EntityElementCube> Cubes {get; set;}
        public List<EntityElement> Submodels {get; set;}

        public bool HasRotation => RotationAngleX != 0 || RotationAngleY != 0 || RotationAngleZ != 0;


        public EntityElement()
        {
            Cubes = new List<EntityElementCube>();
            Submodels = new List<EntityElement>();
        }

        public EntityElement(string name) : this()
        {
            Name = name;
        }
    }
}

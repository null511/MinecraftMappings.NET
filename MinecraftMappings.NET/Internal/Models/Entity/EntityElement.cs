using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityElement
    {
        //public string Name;

        public string? Id;
        public string? Part;
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
        public bool Attach;
        public float Scale;

        public List<EntityElementCube> Boxes;
        public List<EntityElement> Submodels;
        public EntityModelPart? Model;

        // TODO: Add epsilon check!
        public bool HasRotation => RotationAngleX != 0 || RotationAngleY != 0 || RotationAngleZ != 0;


        public EntityElement()
        {
            Boxes = new List<EntityElementCube>();
            Submodels = new List<EntityElement>();
            Scale = 1.0f;
        }

        public EntityElement(string id) : this()
        {
            Id = id;
        }
    }
}

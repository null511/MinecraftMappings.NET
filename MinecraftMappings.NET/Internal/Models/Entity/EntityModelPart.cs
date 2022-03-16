using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityModelPart
    {
        //public string BaseId {get; set;}
        //public string Id {get; set;}
        //public string Part {get; set;}
        //public bool Attach {get; set;}
        //public float Scale {get; set;}
        public string Texture;
        public Vector2 TextureSize;
        public List<EntityElement> Submodels;

        
        public EntityModelPart()
        {
            Submodels = new List<EntityElement>();
        }
    }
}

using System.Collections.Generic;
using SharpDX;

namespace MinecraftMappings.Internal.Models.Entity
{
    public abstract class EntityModelVersion : Versionable
    {
        public string Id {get; set;}
        //public string Path {get; set;}
        //public string MinVersion {get; set;}
        //public string MaxVersion {get; set;}
        //public int FrameCount {get; set;} = 1;
        public Vector2 TextureSize;

        public List<EntityElement> Elements {get; set;}
        public List<UVRegion> UVMappings {get; set;}



        protected EntityModelVersion()
        {
            Elements = new List<EntityElement>();
            UVMappings = new List<UVRegion>();
        }
    }
}

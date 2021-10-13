using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Block
{
    public class BlockModelVersion : Versionable
    {
        public string Id {get; set;}
        public string Path {get; set;}
        public string Parent {get; set;}
        public Dictionary<string, string> Textures {get; set;}
        public List<ModelElement> Elements {get; set;}


        public BlockModelVersion()
        {
            Textures = new Dictionary<string, string>();
            Elements = new List<ModelElement>();
        }
    }
}

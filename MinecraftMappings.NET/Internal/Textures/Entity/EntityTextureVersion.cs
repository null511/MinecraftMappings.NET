using System;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public abstract class EntityTextureVersion
    {
        public string? Id {get; set;}
        public string? Path {get; set;}
        public GameVersion? MinVersion {get; set;}
        public GameVersion? MaxVersion {get; set;}
        public int FrameCount {get; set;} = 1;
        public Type? BaseLayer {get; set;}
        public Type? DefaultModel {get; set;}
    }
}

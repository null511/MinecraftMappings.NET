using System;

namespace MinecraftMappings.Internal.Textures.Block
{
    public abstract class BlockTextureVersion
    {
        public string? Id {get; set;}
        public int? PackVersion {get; set;}
        public GameVersion? MinVersion {get; set;}
        public GameVersion? MaxVersion {get; set;}
        public int FrameCount {get; set;} = 1;
        public Type? DefaultModel {get; set;}
    }
}

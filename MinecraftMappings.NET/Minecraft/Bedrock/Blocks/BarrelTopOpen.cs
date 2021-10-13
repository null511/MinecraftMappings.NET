using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BarrelTopOpen : BedrockBlockTexture
    {
        public BarrelTopOpen() : base("Barrel Top, Open")
        {
            AddVersion("barrel_top_open")
                .WithMinVersion(new GameVersion(1, 9))
                .MapsToJavaBlock<Java.Textures.Block.BarrelTopOpen>();
        }
    }
}

using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BarrelSide : BedrockBlockTexture
    {
        public BarrelSide() : base("Barrel Side")
        {
            AddVersion("barrel_side")
                .WithMinVersion(new GameVersion(1, 9))
                .MapsToJavaBlock<Java.Textures.Block.BarrelSide>();
        }
    }
}

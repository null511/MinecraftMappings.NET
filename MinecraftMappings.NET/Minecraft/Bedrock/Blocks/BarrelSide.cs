using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BarrelSide : BedrockBlockData
    {
        public BarrelSide() : base("Barrel Side")
        {
            AddVersion("barrel_side")
                .WithMinVersion(new GameVersion(1, 9))
                .MapsToJavaBlock<Java.Textures.Block.BarrelSide>();
        }
    }
}

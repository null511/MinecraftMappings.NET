using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BarrelBottom : BedrockBlockData
    {
        public BarrelBottom() : base("Barrel Bottom")
        {
            AddVersion("barrel_bottom")
                .WithMinVersion(new GameVersion(1, 9))
                .MapsToJavaBlock<Java.Textures.Block.BarrelBottom>();
        }
    }
}

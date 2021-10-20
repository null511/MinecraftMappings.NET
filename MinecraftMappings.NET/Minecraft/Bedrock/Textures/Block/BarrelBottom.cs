using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BarrelBottom : BedrockBlockTexture
    {
        public BarrelBottom() : base("Barrel Bottom")
        {
            AddVersion("barrel_bottom")
                .WithMinVersion(new GameVersion(1, 9))
                .MapsToJavaBlock<Java.Textures.Block.BarrelBottom>();
        }
    }
}

using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class AncientDebrisSide : BedrockBlockTexture
    {
        public AncientDebrisSide() : base("Ancient Debris, Side")
        {
            AddVersion("ancient_debris_side")
                .WithMinVersion(new GameVersion(1, 16))
                .MapsToJavaBlock<Java.Textures.Block.AncientDebrisSide>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AncientDebrisSide : JavaBlockTexture
    {
        public AncientDebrisSide() : base("Ancient Debris, Side")
        {
            AddVersion("ancient_debris_side")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.AncientDebris>()
                .MapsToBedrockBlock<BedrockBlocks.AncientDebrisSide>();
        }
    }
}

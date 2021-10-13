using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronSide : JavaBlockTexture
    {
        public CauldronSide() : base("Cauldron, Side")
        {
            AddVersion("cauldron_side")
                .WithDefaultModel<Java.Models.Block.Cauldron>();
                //.MapsToBedrockBlock<BedrockBlocks.CauldronSide>();
        }
    }
}

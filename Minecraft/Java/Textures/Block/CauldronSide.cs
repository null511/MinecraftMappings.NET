using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronSide : JavaBlockData
    {
        public CauldronSide() : base("Cauldron, Side")
        {
            AddVersion("cauldron_side")
                .WithDefaultModel<Java.Models.Block.Cauldron>();
                //.MapsToBedrockBlock<BedrockBlocks.CauldronSide>();
        }
    }
}

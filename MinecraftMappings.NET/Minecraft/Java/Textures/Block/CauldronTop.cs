using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronTop : JavaBlockData
    {
        public CauldronTop() : base("Cauldron, Top")
        {
            AddVersion("cauldron_top")
                .WithDefaultModel<Java.Models.Block.Cauldron>();
                //.MapsToBedrockBlock<BedrockBlocks.CauldronTop>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronTop : JavaBlockTexture
    {
        public CauldronTop() : base("Cauldron, Top")
        {
            AddVersion("cauldron_top")
                .WithDefaultModel<Java.Models.Block.Cauldron>();
                //.MapsToBedrockBlock<BedrockBlocks.CauldronTop>();
        }
    }
}

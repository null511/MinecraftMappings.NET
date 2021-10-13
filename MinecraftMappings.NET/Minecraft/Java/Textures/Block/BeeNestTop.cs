using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestTop : JavaBlockTexture
    {
        public BeeNestTop() : base("Bee Nest Top")
        {
            AddVersion("bee_nest_top")
                //.WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<BedrockBlocks.BeeNestTop>();
        }
    }
}

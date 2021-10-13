using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestSide : JavaBlockTexture
    {
        public BeeNestSide() : base("Bee Nest Side")
        {
            AddVersion("bee_nest_side")
                //.WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<BedrockBlocks.BeeNestSide>();
        }
    }
}

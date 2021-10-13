using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestFrontHoney : JavaBlockTexture
    {
        public BeeNestFrontHoney() : base("Bee Nest Front, Honey")
        {
            AddVersion("bee_nest_front_honey")
                //.WithDefaultModel<Java.Models.Block.BeeNest>()
                .MapsToBedrockBlock<BedrockBlocks.BeeNestFrontHoney>();
        }
    }
}

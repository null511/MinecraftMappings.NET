using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestFront : JavaBlockTexture
    {
        public BeeNestFront() : base("Bee Nest Front")
        {
            AddVersion("bee_nest_front")
                //.WithDefaultModel<BeeNest>()
                .MapsToBedrockBlock<BedrockBlocks.BeeNestFront>();
        }
    }
}

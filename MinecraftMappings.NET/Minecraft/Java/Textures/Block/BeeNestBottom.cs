using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestBottom : JavaBlockTexture
    {
        public BeeNestBottom() : base("Bee Nest Bottom")
        {
            AddVersion("bee_nest_bottom")
                .MapsToBedrockBlock<BedrockBlocks.BeeNestBottom>();
        }
    }
}

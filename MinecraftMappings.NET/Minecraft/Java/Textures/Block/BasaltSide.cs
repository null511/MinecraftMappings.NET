using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BasaltSide : JavaBlockTexture
    {
        public BasaltSide() : base("Basalt Side")
        {
            AddVersion("basalt_side")
                .WithDefaultModel<Java.Models.Block.Basalt>()
                .MapsToBedrockBlock<BedrockBlocks.BasaltSide>();
        }
    }
}

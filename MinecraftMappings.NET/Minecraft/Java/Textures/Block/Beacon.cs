using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beacon : JavaBlockTexture
    {
        public Beacon() : base("Beacon")
        {
            AddVersion("beacon")
                .WithMinVersion("1.4.2")
                .WithDefaultModel<Java.Models.Block.Beacon>()
                .MapsToBedrockBlock<BedrockBlocks.Beacon>();
        }
    }
}

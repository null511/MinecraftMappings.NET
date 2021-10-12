using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beacon : JavaBlockData
    {
        public Beacon() : base("Beacon")
        {
            AddVersion("beacon")
                .WithMinVersion("1.4.2")
                .MapsToBedrockBlock<BedrockBlocks.Beacon>();
        }
    }
}

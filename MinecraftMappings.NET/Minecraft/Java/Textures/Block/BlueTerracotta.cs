using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueTerracotta : JavaBlockTexture
    {
        public BlueTerracotta() : base("Blue Terracotta")
        {
            AddVersion("blue_terracotta")
                .MapsToBedrockBlock<BedrockBlocks.HardenedClayStainedBlue>();
        }
    }
}

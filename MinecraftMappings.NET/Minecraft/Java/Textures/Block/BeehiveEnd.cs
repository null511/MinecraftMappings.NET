using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveEnd : JavaBlockTexture
    {
        public BeehiveEnd() : base("Beehive End")
        {
            AddVersion("beehive_end")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<BedrockBlocks.BeehiveTop>();
        }
    }
}

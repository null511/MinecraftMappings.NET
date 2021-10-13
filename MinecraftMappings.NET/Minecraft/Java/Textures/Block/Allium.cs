using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Allium : JavaBlockTexture
    {
        public Allium() : base("Allium")
        {
            AddVersion("allium")
                .WithDefaultModel<Java.Models.Block.Allium>()
                .MapsToBedrockBlock<BedrockBlocks.FlowerAllium>();
        }
    }
}

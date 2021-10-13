using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Dandelion : JavaBlockTexture
    {
        public Dandelion() : base("Dandelion")
        {
            AddVersion("dandelion")
                .WithDefaultModel<Java.Models.Block.Dandelion>();
                //.MapsToBedrockBlock<BedrockBlocks.FlowerDandelion>();
        }
    }
}

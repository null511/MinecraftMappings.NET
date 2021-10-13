using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Andesite : JavaBlockTexture
    {
        public Andesite() : base("Andesite")
        {
            AddVersion("andesite")
                .WithDefaultModel<Java.Models.Block.Andesite>()
                .MapsToBedrockBlock<BedrockBlocks.StoneAndesite>();
        }
    }
}

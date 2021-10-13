using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CactusTop : JavaBlockTexture
    {
        public CactusTop() : base("Cactus, Top")
        {
            AddVersion("cactus_top")
                .WithDefaultModel<Java.Models.Block.Cactus>();
            //.MapsToBedrockBlock<BedrockBlocks.CactusBottom>();
        }
    }
}

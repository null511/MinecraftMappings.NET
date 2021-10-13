using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BasaltTop : JavaBlockTexture
    {
        public BasaltTop() : base("Basalt Top")
        {
            AddVersion("basalt_top")
                .WithDefaultModel<Java.Models.Block.Basalt>()
                .MapsToBedrockBlock<BedrockBlocks.BasaltTop>();
        }
    }
}

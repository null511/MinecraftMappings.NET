using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Lever : JavaBlockTexture
    {
        public Lever() : base("Lever")
        {
            AddVersion("lever")
                .WithDefaultModel<Java.Models.Block.Lever>();
                //.MapsToBedrockBlock<BedrockBlocks.Brick>();
        }
    }
}

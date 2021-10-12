using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Lever : JavaBlockData
    {
        public Lever() : base("Lever")
        {
            AddVersion("lever")
                .WithDefaultModel<Java.Models.Block.Lever>();
                //.MapsToBedrockBlock<BedrockBlocks.Brick>();
        }
    }
}

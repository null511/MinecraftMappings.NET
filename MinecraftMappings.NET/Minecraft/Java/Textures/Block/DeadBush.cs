using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBush : JavaBlockTexture
    {
        public DeadBush() : base("Dead Bush")
        {
            AddVersion("dead_bush")
                .WithDefaultModel<Java.Models.Block.DeadBush>();
                //.MapsToBedrockBlock<BedrockBlocks.DeadBush>();
        }
    }
}

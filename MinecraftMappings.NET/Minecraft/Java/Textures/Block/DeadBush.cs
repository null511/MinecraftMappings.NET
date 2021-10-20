using MinecraftMappings.Internal.Textures.Block;

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

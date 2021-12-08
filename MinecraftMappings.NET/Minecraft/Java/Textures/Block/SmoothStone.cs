using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmoothStone : JavaBlockTexture
    {
        public SmoothStone() : base("Smooth Stone")
        {
            AddVersion("smooth_stone");
                //.WithDefaultModel<Java.Models.Block.SmoothStone>()
                //.MapsToBedrockBlock<BedrockBlocks.SmoothStone>();
        }
    }
}

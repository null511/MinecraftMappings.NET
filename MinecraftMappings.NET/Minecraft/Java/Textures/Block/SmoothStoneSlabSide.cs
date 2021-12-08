using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmoothStoneSlabSide : JavaBlockTexture
    {
        public SmoothStoneSlabSide() : base("Smooth Stone Slab Side")
        {
            AddVersion("smooth_stone_slab_side");
                //.WithDefaultModel<Java.Models.Block.SmoothStoneSlab>()
                //.MapsToBedrockBlock<BedrockBlocks.SmoothStoneSlabSide>();
        }
    }
}

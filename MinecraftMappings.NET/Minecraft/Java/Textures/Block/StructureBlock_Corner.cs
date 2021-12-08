using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StructureBlock_Corner : JavaBlockTexture
    {
        public StructureBlock_Corner() : base("Structure Block, Corner")
        {
            AddVersion("structure_block_corner");
                //.WithDefaultModel<Java.Models.Block.StructureBlockCorner>()
                //.MapsToBedrockBlock<BedrockBlocks.StructureBlockCorner>();
        }
    }
}

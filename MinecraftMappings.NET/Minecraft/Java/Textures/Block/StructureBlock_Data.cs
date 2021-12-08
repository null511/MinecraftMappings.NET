using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StructureBlock_Data : JavaBlockTexture
    {
        public StructureBlock_Data() : base("Structure Block, Data")
        {
            AddVersion("structure_block_data");
                //.WithDefaultModel<Java.Models.Block.StructureBlockData>()
                //.MapsToBedrockBlock<BedrockBlocks.StructureBlockData>();
        }
    }
}

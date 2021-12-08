using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StructureBlock_Load : JavaBlockTexture
    {
        public StructureBlock_Load() : base("Structure Block, Load")
        {
            AddVersion("structure_block_load");
                //.WithDefaultModel<Java.Models.Block.StructureBlockLoad>()
                //.MapsToBedrockBlock<BedrockBlocks.StructureBlockLoad>();
        }
    }
}

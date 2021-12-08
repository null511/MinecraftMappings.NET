using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StructureBlock_Save : JavaBlockTexture
    {
        public StructureBlock_Save() : base("Structure Block, Save")
        {
            AddVersion("structure_block_save");
                //.WithDefaultModel<Java.Models.Block.StructureBlockSave>()
                //.MapsToBedrockBlock<BedrockBlocks.StructureBlockSave>();
        }
    }
}

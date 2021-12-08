using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StructureBlock : JavaBlockTexture
    {
        public StructureBlock() : base("Structure Block")
        {
            AddVersion("structure_block");
                //.WithDefaultModel<Java.Models.Block.StructureBlock>()
                //.MapsToBedrockBlock<BedrockBlocks.StructureBlock>();
        }
    }
}

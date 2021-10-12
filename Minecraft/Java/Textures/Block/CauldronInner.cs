using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronInner : JavaBlockData
    {
        public CauldronInner() : base("Cauldron, Inner")
        {
            AddVersion("cauldron_inner")
                .WithDefaultModel<Java.Models.Block.Cauldron>();
                //.MapsToBedrockBlock<BedrockBlocks.CauldronInner>();
        }
    }
}

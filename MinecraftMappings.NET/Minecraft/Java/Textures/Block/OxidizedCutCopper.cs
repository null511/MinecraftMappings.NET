using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OxidizedCutCopper : JavaBlockTexture
    {
        public OxidizedCutCopper() : base("Oxidized Cut Copper")
        {
            AddVersion("oxidized_cut_copper");
                //.WithDefaultModel<Java.Models.Block.OxidizedCutCopper>()
                //.MapsToBedrockBlock<BedrockBlocks.OxidizedCutCopper>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OxidizedCopper : JavaBlockTexture
    {
        public OxidizedCopper() : base("Oxidized Copper")
        {
            AddVersion("oxidized_copper");
                //.WithDefaultModel<Java.Models.Block.OxidizedCopper>()
                //.MapsToBedrockBlock<BedrockBlocks.OxidizedCopper>();
        }
    }
}

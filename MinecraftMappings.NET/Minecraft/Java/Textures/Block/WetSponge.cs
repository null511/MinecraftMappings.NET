using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WetSponge : JavaBlockTexture
    {
        public WetSponge() : base("Wet Sponge")
        {
            AddVersion("wet_sponge");
                //.WithDefaultModel<Java.Models.Block.WetSponge>()
                //.MapsToBedrockBlock<BedrockBlocks.WetSponge>();
        }
    }
}

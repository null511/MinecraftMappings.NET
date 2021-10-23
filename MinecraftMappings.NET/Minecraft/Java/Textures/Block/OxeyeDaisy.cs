using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OxeyeDaisy : JavaBlockTexture
    {
        public OxeyeDaisy() : base("Oxeye Daisy")
        {
            AddVersion("oxeye_daisy")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.OxeyeDaisy>();
                //.MapsToBedrockBlock<BedrockBlocks.OxeyeDaisy>();
        }
    }
}

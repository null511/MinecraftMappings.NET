using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OxeyeDaisy : JavaBlockTexture
    {
        public OxeyeDaisy() : base("Oxeye Daisy")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "oxeye_daisy")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.OxeyeDaisy>();
                //.MapsToBedrockBlock<BedrockBlocks.OxeyeDaisy>();
        }
    }
}

using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cobweb : JavaBlockTexture
    {
        public Cobweb() : base("Cobweb")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cobweb")
                .WithDefaultModel<Java.Models.Block.Cobweb>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Web>();
        }
    }
}

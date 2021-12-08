using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherPortal : JavaBlockTexture
    {
        public NetherPortal() : base("Nether Portal")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("nether_portal");
                //.WithDefaultModel<Java.Models.Block.NetherPortal>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherPortal>();
        }
    }
}

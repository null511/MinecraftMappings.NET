using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneDust_Overlay : JavaBlockTexture
    {
        public RedstoneDust_Overlay() : base("Redstone Dust, Overlay")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("redstone_dust_overlay");
                //.WithDefaultModel<Java.Models.Block.RedstoneDustOverlay>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneDustOverlay>();
        }
    }
}

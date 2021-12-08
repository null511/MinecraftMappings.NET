using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneDust_Dot : JavaBlockTexture
    {
        public RedstoneDust_Dot() : base("Redstone Dust, Dot")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("redstone_dust_dot");
                //.WithDefaultModel<Java.Models.Block.RedstoneDustDot>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneDustDot>();
        }
    }
}

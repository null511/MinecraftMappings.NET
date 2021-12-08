using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneDust_Line0 : JavaBlockTexture
    {
        public RedstoneDust_Line0() : base("Redstone Dust, Line 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("redstone_dust_line0");
                //.WithDefaultModel<Java.Models.Block.RedstoneDust_Line0>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneDust_Line0>();
        }
    }
}

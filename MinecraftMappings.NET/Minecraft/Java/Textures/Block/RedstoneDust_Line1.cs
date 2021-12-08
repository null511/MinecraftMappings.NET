using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneDust_Line1 : JavaBlockTexture
    {
        public RedstoneDust_Line1() : base("Redstone Dust, Line 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("redstone_dust_line1");
                //.WithDefaultModel<Java.Models.Block.RedstoneDust_Line1>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneDust_Line1>();
        }
    }
}

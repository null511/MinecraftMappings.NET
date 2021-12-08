using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneDownMiddle : JavaBlockTexture
    {
        public PointedDripstoneDownMiddle() : base("Pointed Dripstone Down, Middle")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_down_middle");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneDownMiddle>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneDownMiddle>();
        }
    }
}

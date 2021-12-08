using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneUpTip : JavaBlockTexture
    {
        public PointedDripstoneUpTip() : base("Pointed Dripstone Up, Tip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_up_tip");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneUpTip>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneUpTip>();
        }
    }
}

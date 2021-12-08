using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneDownTip : JavaBlockTexture
    {
        public PointedDripstoneDownTip() : base("Pointed Dripstone Down, Tip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_down_tip");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneDownTip>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneDownTip>();
        }
    }
}

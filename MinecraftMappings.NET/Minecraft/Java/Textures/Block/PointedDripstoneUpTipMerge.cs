using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneUpTipMerge : JavaBlockTexture
    {
        public PointedDripstoneUpTipMerge() : base("Pointed Dripstone Up, Tip Merge")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_up_tip_merge");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneUpTipMerge>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneUpTipMerge>();
        }
    }
}

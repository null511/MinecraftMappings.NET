using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneDownTipMerge : JavaBlockTexture
    {
        public PointedDripstoneDownTipMerge() : base("Pointed Dripstone Down, Tip Merge")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_down_tip_merge");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneDownTipMerge>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneDownTipMerge>();
        }
    }
}

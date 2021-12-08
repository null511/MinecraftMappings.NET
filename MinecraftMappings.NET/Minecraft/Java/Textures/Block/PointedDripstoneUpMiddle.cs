using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneUpMiddle : JavaBlockTexture
    {
        public PointedDripstoneUpMiddle() : base("Pointed Dripstone Up, Middle")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_up_middle");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneUpMiddle>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneUpMiddle>();
        }
    }
}

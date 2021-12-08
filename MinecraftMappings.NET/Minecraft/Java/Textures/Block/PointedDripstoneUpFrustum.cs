using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneUpFrustum : JavaBlockTexture
    {
        public PointedDripstoneUpFrustum() : base("Pointed Dripstone Up, Frustum")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_up_frustum");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneUpFrustum>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneUpFrustum>();
        }
    }
}

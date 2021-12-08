using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneDownFrustum : JavaBlockTexture
    {
        public PointedDripstoneDownFrustum() : base("Pointed Dripstone Down, Frustum")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_down_frustum");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneDownFrustum>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneDownFrustum>();
        }
    }
}

using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneUpBase : JavaBlockTexture
    {
        public PointedDripstoneUpBase() : base("Pointed Dripstone Up, Base")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_up_base");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneUpBase>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneUpBase>();
        }
    }
}

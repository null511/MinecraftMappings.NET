using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PointedDripstoneDownBase : JavaBlockTexture
    {
        public PointedDripstoneDownBase() : base("Pointed Dripstone Down, Base")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pointed_dripstone_down_base");
                //.WithDefaultModel<Java.Models.Block.PointedDripstoneDownBase>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PointedDripstoneDownBase>();
        }
    }
}

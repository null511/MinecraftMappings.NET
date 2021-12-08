using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TallSeagrassBottom : JavaBlockTexture
    {
        public TallSeagrassBottom() : base("Tall Seagrass Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tall_seagrass_bottom");
                //.WithDefaultModel<Java.Models.Block.TallSeaGrassBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_SeaGrassBottom>();
        }
    }
}

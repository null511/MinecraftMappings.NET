using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TallSeagrassTop : JavaBlockTexture
    {
        public TallSeagrassTop() : base("Tall Seagrass Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tall_seagrass_top");
                //.WithDefaultModel<Java.Models.Block.TallSeaGrassTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_SeaGrassTop>();
        }
    }
}

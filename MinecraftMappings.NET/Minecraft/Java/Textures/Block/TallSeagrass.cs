using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TallSeagrass : JavaBlockTexture
    {
        public TallSeagrass() : base("Tall Seagrass")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tall_seagrass");
                //.WithDefaultModel<Java.Models.Block.TallSeagrass>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_Seagrass>();
        }
    }
}

using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TallGrassTop : JavaBlockTexture
    {
        public TallGrassTop() : base("Tall Grass Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tall_grass_top")
                .WithDefaultModel<Java.Models.Block.TallGrassTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_GrassTop>();
        }
    }
}

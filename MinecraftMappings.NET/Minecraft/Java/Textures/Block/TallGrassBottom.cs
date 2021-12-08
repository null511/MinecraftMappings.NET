using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TallGrassBottom : JavaBlockTexture
    {
        public TallGrassBottom() : base("Tall Grass Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tall_grass_bottom")
                .WithDefaultModel<Java.Models.Block.TallGrassBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_GrassBottom>();
        }
    }
}

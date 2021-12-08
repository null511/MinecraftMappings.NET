using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TallGrass : JavaBlockTexture
    {
        public TallGrass() : base("Tall Grass")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("tall_grass")
                .WithDefaultModel<Java.Models.Block.TallGrass>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_Grass>();
        }
    }
}

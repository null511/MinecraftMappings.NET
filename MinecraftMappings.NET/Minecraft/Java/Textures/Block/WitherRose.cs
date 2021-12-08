using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WitherRose : JavaBlockTexture
    {
        public WitherRose() : base("Wither Rose")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wither_rose");
                //.WithDefaultModel<Java.Models.Block.WitherRose>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WitherRose>();
        }
    }
}

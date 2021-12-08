using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PeonyTop : JavaBlockTexture
    {
        public PeonyTop() : base("Peony Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("peony_top");
                //.WithDefaultModel<Java.Models.Block.PeonyTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerPeonyTop>();
        }
    }
}

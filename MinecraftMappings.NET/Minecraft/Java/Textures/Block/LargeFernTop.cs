using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LargeFernTop : JavaBlockTexture
    {
        public LargeFernTop() : base("Large Fern Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("large_fern_top")
                .WithDefaultModel<Java.Models.Block.LargeFernTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_FernTop>();
        }
    }
}

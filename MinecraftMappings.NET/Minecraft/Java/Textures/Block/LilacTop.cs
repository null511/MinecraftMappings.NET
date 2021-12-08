using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LilacTop : JavaBlockTexture
    {
        public LilacTop() : base("Lilac Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("lilac_top");
                //.WithDefaultModel<Java.Models.Block.LilacTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LilacTop>();
        }
    }
}

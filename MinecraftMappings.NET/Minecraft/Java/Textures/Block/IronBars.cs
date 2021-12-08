using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronBars : JavaBlockTexture
    {
        public IronBars() : base("Iron Bars")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("iron_bars");
                //.WithDefaultModel<Java.Models.Block.IronBars>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.IronBars>();
        }
    }
}

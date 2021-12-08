using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LargeAmethystBud : JavaBlockTexture
    {
        public LargeAmethystBud() : base("Large Amethyst Bud")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "large_amethyst_bud")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.LargeAmethystBud>()
                //.MapsToBedrockBlock<BedrockBlocks.LargeAmethystBud>();
        }
    }
}

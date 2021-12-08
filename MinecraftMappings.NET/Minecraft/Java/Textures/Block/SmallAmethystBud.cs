using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmallAmethystBud : JavaBlockTexture
    {
        public SmallAmethystBud() : base("Small Amethyst Bud")
        {
            AddVersion(7, "small_amethyst_bud")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.SmallAmethystBud>()
                //.MapsToBedrockBlock<BedrockBlocks.SmallAmethystBud>();
        }
    }
}

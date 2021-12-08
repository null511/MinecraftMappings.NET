using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SporeBlossomBase : JavaBlockTexture
    {
        public SporeBlossomBase() : base("Spore Blossom Base")
        {
            AddVersion("spore_blossom_base");
                //.WithDefaultModel<Java.Models.Block.SporeBlossomBase>()
                //.MapsToBedrockBlock<BedrockBlocks.SporeBlossomBase>();
        }
    }
}

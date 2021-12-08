using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledPolishedBlackstone : JavaBlockTexture
    {
        public ChiseledPolishedBlackstone() : base("Chiseled Polished Blackstone")
        {
            AddVersion("chiseled_polished_blackstone");
                //.WithDefaultModel<Java.Models.Block.ChiseledPolishedBlackstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledPolishedBlackstone>();
        }
    }
}

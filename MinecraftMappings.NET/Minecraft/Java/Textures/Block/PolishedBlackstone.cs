using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedBlackstone : JavaBlockTexture
    {
        public PolishedBlackstone() : base("Polished Blackstone")
        {
            AddVersion("polished_blackstone");
                //.WithDefaultModel<Java.Models.Block.PolishedBlackstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PolishedBlackstone>();
        }
    }
}

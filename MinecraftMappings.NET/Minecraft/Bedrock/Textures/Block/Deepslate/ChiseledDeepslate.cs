using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class ChiseledDeepslate : BedrockBlockTexture
    {
        public ChiseledDeepslate() : base("Chiseled Deepslate")
        {
            AddVersion("chiseled_deepslate")
                .MapsToJavaBlock<Java.Textures.Block.ChiseledDeepslate>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BambooStem : BedrockBlockTexture
    {
        public BambooStem() : base("Bamboo Stem")
        {
            AddVersion("bamboo_stem")
                .MapsToJavaBlock<BambooStalk>();
        }
    }
}

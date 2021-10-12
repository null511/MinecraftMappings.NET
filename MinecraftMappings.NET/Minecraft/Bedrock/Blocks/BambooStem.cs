using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BambooStem : BedrockBlockData
    {
        public BambooStem() : base("Bamboo Stem")
        {
            AddVersion("bamboo_stem")
                .MapsToJavaBlock<BambooStalk>();
        }
    }
}

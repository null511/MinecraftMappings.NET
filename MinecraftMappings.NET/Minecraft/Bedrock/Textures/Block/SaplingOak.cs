using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class SaplingOak : BedrockBlockTexture
    {
        public SaplingOak() : base("Sapling Oak")
        {
            AddVersion("sapling_oak")
                .MapsToJavaBlock<OakSapling>();
        }
    }
}

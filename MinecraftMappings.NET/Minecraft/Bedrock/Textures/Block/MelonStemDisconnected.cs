using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MelonStemDisconnected : BedrockBlockTexture
    {
        public MelonStemDisconnected() : base("Melon Stem, Disconnected")
        {
            AddVersion("melon_stem_disconnected")
                .MapsToJavaBlock<Java.Textures.Block.MelonStem>();
        }
    }
}

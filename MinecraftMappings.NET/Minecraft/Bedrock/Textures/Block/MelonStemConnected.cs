using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MelonStemConnected : BedrockBlockTexture
    {
        public MelonStemConnected() : base("Melon Stem, Connected")
        {
            AddVersion("melon_stem_connected")
                .MapsToJavaBlock<Java.Textures.Block.AttachedMelonStem>();
        }
    }
}

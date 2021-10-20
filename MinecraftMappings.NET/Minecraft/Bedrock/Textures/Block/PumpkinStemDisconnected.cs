using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class PumpkinStemDisconnected : BedrockBlockTexture
    {
        public PumpkinStemDisconnected() : base("Pumpkin Stem, Disconnected")
        {
            AddVersion("pumpkin_stem_disconnected")
                .MapsToJavaBlock<Java.Textures.Block.PumpkinStem>();
        }
    }
}

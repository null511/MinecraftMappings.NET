using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class PumpkinStemConnected : BedrockBlockTexture
    {
        public PumpkinStemConnected() : base("Pumpkin Stem, Connected")
        {
            AddVersion("pumpkin_stem_connected")
                .MapsToJavaBlock<Java.Textures.Block.AttachedPumpkinStem>();
        }
    }
}

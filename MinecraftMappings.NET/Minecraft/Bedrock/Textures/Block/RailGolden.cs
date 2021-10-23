using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailGolden : BedrockBlockTexture
    {
        public RailGolden() : base("Rail Golden")
        {
            AddVersion("rail_golden")
                .MapsToJavaBlock<Java.Textures.Block.PoweredRail>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailGoldenPowered : BedrockBlockTexture
    {
        public RailGoldenPowered() : base("Rail Golden, Powered")
        {
            AddVersion("rail_golden_powered")
                .MapsToJavaBlock<Java.Textures.Block.PoweredRailOn>();
        }
    }
}

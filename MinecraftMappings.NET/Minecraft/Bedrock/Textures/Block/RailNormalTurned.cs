using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailNormalTurned : BedrockBlockTexture
    {
        public RailNormalTurned() : base("Rail Normal, Turned")
        {
            AddVersion("rail_normal_turned")
                .MapsToJavaBlock<Java.Textures.Block.RailCorner>();
        }
    }
}

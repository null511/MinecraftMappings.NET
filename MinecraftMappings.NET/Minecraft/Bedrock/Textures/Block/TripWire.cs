using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class TripWire : BedrockBlockTexture
    {
        public TripWire() : base("Trip Wire")
        {
            AddVersion("trip_wire")
                .MapsToJavaBlock<Java.Textures.Block.Tripwire>();
        }
    }
}

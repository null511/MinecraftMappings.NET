using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class TripWireSource : BedrockBlockTexture
    {
        public TripWireSource() : base("Trip Wire Source")
        {
            AddVersion("trip_wire_source")
                .MapsToJavaBlock<Java.Textures.Block.TripwireHook>();
        }
    }
}

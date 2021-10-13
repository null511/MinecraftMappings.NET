using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class RailActivator : BedrockBlockTexture
    {
        public RailActivator() : base("Rail Activator")
        {
            AddVersion("rail_activator")
                .MapsToJavaBlock<Java.Textures.Block.ActivatorRail>();
        }
    }
}

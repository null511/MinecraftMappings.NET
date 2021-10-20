using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
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

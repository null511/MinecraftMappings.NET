using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Honeycomb : BedrockBlockTexture
    {
        public Honeycomb() : base("Honeycomb")
        {
            AddVersion("honeycomb")
                .WithMinVersion("1.15")
                .MapsToJavaBlock<Java.Textures.Block.HoneycombBlock>();
        }
    }
}

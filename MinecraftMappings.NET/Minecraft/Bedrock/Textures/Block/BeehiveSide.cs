using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeehiveSide : BedrockBlockTexture
    {
        public BeehiveSide() : base("Beehive Side")
        {
            AddVersion("beehive_side")
                .MapsToJavaBlock<Java.Textures.Block.BeehiveSide>();
        }
    }
}

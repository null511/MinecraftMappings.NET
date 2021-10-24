using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ComposterBottom : BedrockBlockTexture
    {
        public ComposterBottom() : base("Composter Bottom")
        {
            AddVersion("composter_bottom")
                .MapsToJavaBlock<Java.Textures.Block.ComposterBottom>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ComposterSide : BedrockBlockTexture
    {
        public ComposterSide() : base("Composter Side")
        {
            AddVersion("composter_side")
                .MapsToJavaBlock<Java.Textures.Block.ComposterSide>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LoomSide : BedrockBlockTexture
    {
        public LoomSide() : base("Loom Side")
        {
            AddVersion("loom_side")
                .MapsToJavaBlock<Java.Textures.Block.LoomSide>();
        }
    }
}

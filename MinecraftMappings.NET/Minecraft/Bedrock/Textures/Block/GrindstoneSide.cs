using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrindstoneSide : BedrockBlockTexture
    {
        public GrindstoneSide() : base("Grindstone Side")
        {
            AddVersion("grindstone_side")
                .MapsToJavaBlock<Java.Textures.Block.GrindstoneSide>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FurnaceSide : BedrockBlockTexture
    {
        public FurnaceSide() : base("Furnace Side")
        {
            AddVersion("furnace_side")
                .MapsToJavaBlock<Java.Textures.Block.FurnaceSide>();
        }
    }
}

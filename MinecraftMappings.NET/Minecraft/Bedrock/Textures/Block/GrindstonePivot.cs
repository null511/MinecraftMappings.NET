using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrindstonePivot : BedrockBlockTexture
    {
        public GrindstonePivot() : base("Grindstone Pivot")
        {
            AddVersion("grindstone_pivot")
                .MapsToJavaBlock<Java.Textures.Block.GrindstonePivot>();
        }
    }
}

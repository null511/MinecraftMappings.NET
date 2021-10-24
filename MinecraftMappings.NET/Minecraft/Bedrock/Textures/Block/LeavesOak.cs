using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LeavesOak : BedrockBlockTexture
    {
        public LeavesOak() : base("Leaves Oak")
        {
            AddVersion("leaves_oak")
                .MapsToJavaBlock<Java.Textures.Block.OakLeaves>();
        }
    }
}

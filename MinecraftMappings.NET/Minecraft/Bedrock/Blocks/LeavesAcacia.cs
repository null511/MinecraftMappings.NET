using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LeavesAcacia : BedrockBlockTexture
    {
        public LeavesAcacia() : base("Leaves Acacia")
        {
            AddVersion("leaves_acacia")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaLeaves>();
        }
    }
}

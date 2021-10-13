using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LeavesBirch : BedrockBlockTexture
    {
        public LeavesBirch() : base("Leaves Birch")
        {
            AddVersion("leaves_birch")
                .MapsToJavaBlock<Java.Textures.Block.BirchLeaves>();
        }
    }
}

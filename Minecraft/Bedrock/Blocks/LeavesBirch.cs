using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LeavesBirch : BedrockBlockData
    {
        public LeavesBirch() : base("Leaves Birch")
        {
            AddVersion("leaves_birch")
                .MapsToJavaBlock<Java.Textures.Block.BirchLeaves>();
        }
    }
}

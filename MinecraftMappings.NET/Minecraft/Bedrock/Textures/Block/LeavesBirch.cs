using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
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

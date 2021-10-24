using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LeavesBigOak : BedrockBlockTexture
    {
        public LeavesBigOak() : base("Leaves Big Oak")
        {
            AddVersion("leaves_big_oak")
                .MapsToJavaBlock<Java.Textures.Block.DarkOakLeaves>();
        }
    }
}

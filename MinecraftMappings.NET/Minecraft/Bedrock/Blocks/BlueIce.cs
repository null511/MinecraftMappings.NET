using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BlueIce : BedrockBlockTexture
    {
        public BlueIce() : base("Blue Ice")
        {
            AddVersion("blue_ice")
                .MapsToJavaBlock<Java.Textures.Block.BlueIce>();
        }
    }
}

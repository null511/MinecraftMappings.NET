using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueIce : JavaBlockTexture
    {
        public BlueIce() : base("Blue Ice")
        {
            AddVersion("blue_ice")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BlueIce>();
        }
    }
}

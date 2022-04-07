using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HardenedClayStainedBlack : BedrockBlockTexture
    {
        public HardenedClayStainedBlack() : base("Hardened Clay Stained Black")
        {
            AddVersion("hardened_clay_stained_black")
                .MapsToJavaBlock<Java.Textures.Block.BlackTerracotta>();
        }
    }
}

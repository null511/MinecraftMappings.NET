using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class HardenedClayStainedBlack : BedrockBlockTexture
    {
        public HardenedClayStainedBlack() : base("Hardened Clay Stained Black")
        {
            AddVersion("hardened_clay_stained_black")
                .MapsToJavaBlock<BlackTerracotta>();
        }
    }
}

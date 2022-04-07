using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_RedstoneOre : BedrockBlockTexture
    {
        public Deepslate_RedstoneOre() : base("Deepslate Redstone Ore")
        {
            AddVersion("deepslate_redstone_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_RedstoneOre>();
        }
    }
}

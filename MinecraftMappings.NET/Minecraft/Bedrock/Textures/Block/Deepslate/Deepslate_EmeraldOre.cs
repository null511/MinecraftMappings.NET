using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_EmeraldOre : BedrockBlockTexture
    {
        public Deepslate_EmeraldOre() : base("Deepslate Emerald Ore")
        {
            AddVersion("deepslate_emerald_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_EmeraldOre>();
        }
    }
}

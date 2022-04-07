using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_LapisOre : BedrockBlockTexture
    {
        public Deepslate_LapisOre() : base("Deepslate Lapis Ore")
        {
            AddVersion("deepslate_lapis_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_LapisOre>();
        }
    }
}

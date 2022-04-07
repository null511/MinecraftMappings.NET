using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_GoldOre : BedrockBlockTexture
    {
        public Deepslate_GoldOre() : base("Deepslate Gold Ore")
        {
            AddVersion("deepslate_gold_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_GoldOre>();
        }
    }
}

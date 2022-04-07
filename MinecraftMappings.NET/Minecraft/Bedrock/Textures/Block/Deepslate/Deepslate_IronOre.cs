using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_IronOre : BedrockBlockTexture
    {
        public Deepslate_IronOre() : base("Deepslate Iron Ore")
        {
            AddVersion("deepslate_iron_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_IronOre>();
        }
    }
}

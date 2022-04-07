using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_DiamondOre : BedrockBlockTexture
    {
        public Deepslate_DiamondOre() : base("Deepslate Diamond Ore")
        {
            AddVersion("deepslate_diamond_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_DiamondOre>();
        }
    }
}

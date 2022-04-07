using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_CopperOre : BedrockBlockTexture
    {
        public Deepslate_CopperOre() : base("Deepslate Copper Ore")
        {
            AddVersion("deepslate_copper_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_CopperOre>();
        }
    }
}

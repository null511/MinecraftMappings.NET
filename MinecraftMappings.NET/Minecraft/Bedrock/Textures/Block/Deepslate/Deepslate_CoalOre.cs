using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate_CoalOre : BedrockBlockTexture
    {
        public Deepslate_CoalOre() : base("Deepslate, Coal Ore")
        {
            AddVersion("deepslate_coal_ore")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate_CoalOre>();
        }
    }
}

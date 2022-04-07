using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_IronOre : JavaBlockTexture
    {
        public Deepslate_IronOre() : base("Deepslate Iron Ore")
        {
            AddVersion("deepslate_iron_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_IronOre>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.Deepslate_IronOre>();
        }
    }
}

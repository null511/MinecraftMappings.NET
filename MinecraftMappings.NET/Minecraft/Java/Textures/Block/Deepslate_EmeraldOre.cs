using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_EmeraldOre : JavaBlockTexture
    {
        public Deepslate_EmeraldOre() : base("Deepslate Emerald Ore")
        {
            AddVersion("deepslate_emerald_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_EmeraldOre>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.Deepslate_EmeraldOre>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_LapisOre : JavaBlockTexture
    {
        public Deepslate_LapisOre() : base("Deepslate Lapis Ore")
        {
            AddVersion("deepslate_lapis_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_LapisOre>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.Deepslate_LapisOre>();
        }
    }
}

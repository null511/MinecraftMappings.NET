using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_CopperOre : JavaBlockTexture
    {
        public Deepslate_CopperOre() : base("Deepslate Copper Ore")
        {
            AddVersion("deepslate_copper_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_CopperOre>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.Deepslate_CopperOre>();
        }
    }
}

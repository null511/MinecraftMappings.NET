using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_CoalOre : JavaBlockTexture
    {
        public Deepslate_CoalOre() : base("Deepslate Coal Ore")
        {
            AddVersion("deepslate_coal_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_CoalOre>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.Deepslate_CoalOre>();
        }
    }
}

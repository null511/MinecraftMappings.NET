using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_RedstoneOre : JavaBlockTexture
    {
        public Deepslate_RedstoneOre() : base("Deepslate Redstone Ore")
        {
            AddVersion("deepslate_redstone_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_RedstoneOre>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.Deepslate_RedstoneOre>();
        }
    }
}

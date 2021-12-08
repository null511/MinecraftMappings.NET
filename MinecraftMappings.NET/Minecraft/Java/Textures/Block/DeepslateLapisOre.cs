using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateLapisOre : JavaBlockTexture
    {
        public DeepslateLapisOre() : base("Deepslate Lapis Ore")
        {
            AddVersion("deepslate_lapis_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateLapisOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateLapisOre>();
        }
    }
}

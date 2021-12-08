using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GoldOre : JavaBlockTexture
    {
        public GoldOre() : base("Gold Ore")
        {
            AddVersion("gold_ore");
                //.WithDefaultModel<Java.Models.Block.GoldOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GoldOre>();
        }
    }
}

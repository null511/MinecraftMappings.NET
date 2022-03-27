using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_GoldOre : JavaBlockTexture
    {
        public Deepslate_GoldOre() : base("Deepslate Gold Ore")
        {
            AddVersion("deepslate_gold_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_GoldOre>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateGoldOre>();
        }
    }
}

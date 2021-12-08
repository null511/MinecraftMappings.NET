using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateGoldOre : JavaBlockTexture
    {
        public DeepslateGoldOre() : base("Deepslate Gold Ore")
        {
            AddVersion("deepslate_gold_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateGoldOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateGoldOre>();
        }
    }
}

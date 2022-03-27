using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate_DiamondOre : JavaBlockTexture
    {
        public Deepslate_DiamondOre() : base("Deepslate Diamond Ore")
        {
            AddVersion("deepslate_diamond_ore")
                .WithDefaultModel<Java.Models.Block.Deepslate_DiamondOre>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateDiamondOre>();
        }
    }
}

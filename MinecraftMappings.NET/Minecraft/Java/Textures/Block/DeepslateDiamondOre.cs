using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateDiamondOre : JavaBlockTexture
    {
        public DeepslateDiamondOre() : base("Deepslate Diamond Ore")
        {
            AddVersion("deepslate_diamond_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateDiamondOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateDiamondOre>();
        }
    }
}

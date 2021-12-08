using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DiamondOre : JavaBlockTexture
    {
        public DiamondOre() : base("Diamond Ore")
        {
            AddVersion("diamond_ore");
                //.WithDefaultModel<Java.Models.Block.DiamondOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DiamondOre>();
        }
    }
}

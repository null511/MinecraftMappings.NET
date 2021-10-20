using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CopperOre : JavaBlockTexture
    {
        public CopperOre() : base("Copper Ore")
        {
            AddVersion("copper_ore")
                .WithDefaultModel<Java.Models.Block.CopperOre>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CopperOre>();
        }
    }
}

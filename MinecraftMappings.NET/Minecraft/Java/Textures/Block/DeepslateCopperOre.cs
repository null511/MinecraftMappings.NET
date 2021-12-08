using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateCopperOre : JavaBlockTexture
    {
        public DeepslateCopperOre() : base("Deepslate Copper Ore")
        {
            AddVersion("deepslate_copper_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateCopperOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateCopperOre>();
        }
    }
}

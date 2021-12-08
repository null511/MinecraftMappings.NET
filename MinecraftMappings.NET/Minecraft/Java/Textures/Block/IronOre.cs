using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronOre : JavaBlockTexture
    {
        public IronOre() : base("Iron Ore")
        {
            AddVersion("iron_ore");
                //.WithDefaultModel<Java.Models.Block.IronOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.IronOre>();
        }
    }
}

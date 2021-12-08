using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherGoldOre : JavaBlockTexture
    {
        public NetherGoldOre() : base("Nether Gold Ore")
        {
            AddVersion("nether_gold_ore");
                //.WithDefaultModel<Java.Models.Block.NetherGoldOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherGoldOre>();
        }
    }
}

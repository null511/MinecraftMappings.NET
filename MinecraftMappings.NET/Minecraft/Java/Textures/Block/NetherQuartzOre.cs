using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherQuartzOre : JavaBlockTexture
    {
        public NetherQuartzOre() : base("Nether Quartz Ore")
        {
            AddVersion("nether_quartz_ore");
                //.WithDefaultModel<Java.Models.Block.NetherQuartzOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherQuartzOre>();
        }
    }
}

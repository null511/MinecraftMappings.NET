using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedBlackstoneBricks : JavaBlockTexture
    {
        public PolishedBlackstoneBricks() : base("Polished Blackstone Bricks")
        {
            AddVersion("polished_blackstone_bricks");
                //.WithDefaultModel<Java.Models.Block.PolishedBlackstoneBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PolishedBlackstoneBricks>();
        }
    }
}

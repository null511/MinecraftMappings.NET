using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrackedPolishedBlackstoneBricks : JavaBlockTexture
    {
        public CrackedPolishedBlackstoneBricks() : base("Cracked Polished Blackstone Bricks")
        {
            AddVersion("cracked_polished_blackstone_bricks");
                //.WithDefaultModel<Java.Models.Block.CrackedPolishedBlackstoneBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrackedPolishedBlackstoneBricks>();
        }
    }
}

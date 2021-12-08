using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrackedStoneBricks : JavaBlockTexture
    {
        public CrackedStoneBricks() : base("Cracked Stone Bricks")
        {
            AddVersion("cracked_stone_bricks");
                //.WithDefaultModel<Java.Models.Block.CrackedStoneBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrackedStoneBricks>();
        }
    }
}

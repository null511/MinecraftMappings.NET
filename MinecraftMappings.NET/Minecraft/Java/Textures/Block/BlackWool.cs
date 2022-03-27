using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackWool : JavaBlockTexture
    {
        public BlackWool() : base("Black Wool")
        {
            AddVersion("black_wool")
                .WithDefaultModel<Java.Models.Block.BlackWool>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredBlack>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedWool : JavaBlockTexture
    {
        public RedWool() : base("Blue Wool")
        {
            AddVersion("blue_wool")
                .WithMinVersion("1.6.1")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredBlue>();
        }
    }
}

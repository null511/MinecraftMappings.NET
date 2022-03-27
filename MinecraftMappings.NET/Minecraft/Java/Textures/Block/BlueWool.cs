using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueWool : JavaBlockTexture
    {
        public BlueWool() : base("Blue Wool")
        {
            AddVersion("blue_wool")
                .WithDefaultModel<Java.Models.Block.BlueWool>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredBlue>();
        }
    }
}

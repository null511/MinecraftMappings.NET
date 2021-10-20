using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueStainedGlass : JavaBlockTexture
    {
        public BlueStainedGlass() : base("Blue Stained Glass")
        {
            AddVersion("blue_stained_glass")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassBlue>();
        }
    }
}

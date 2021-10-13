using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class PlanksBirch : BedrockBlockTexture
    {
        public PlanksBirch() : base("Planks Birch")
        {
            AddVersion("planks_birch")
                .MapsToJavaBlock<Java.Textures.Block.BirchPlanks>();
        }
    }
}

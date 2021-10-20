using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
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

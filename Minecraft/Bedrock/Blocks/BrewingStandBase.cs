using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BrewingStandBase : BedrockBlockData
    {
        public BrewingStandBase() : base("Brewing Stand Base")
        {
            AddVersion("brewing_stand_base")
                .MapsToJavaBlock<Java.Textures.Block.BrewingStandBase>();
        }
    }
}

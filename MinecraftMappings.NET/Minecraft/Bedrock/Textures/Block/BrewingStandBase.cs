using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BrewingStandBase : BedrockBlockTexture
    {
        public BrewingStandBase() : base("Brewing Stand Base")
        {
            AddVersion("brewing_stand_base")
                .MapsToJavaBlock<Java.Textures.Block.BrewingStandBase>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HopperInside : BedrockBlockTexture
    {
        public HopperInside() : base("Hopper Inside")
        {
            AddVersion("hopper_inside")
                .MapsToJavaBlock<Java.Textures.Block.HopperInside>();
        }
    }
}

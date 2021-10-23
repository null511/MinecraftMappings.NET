using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HopperOutside : BedrockBlockTexture
    {
        public HopperOutside() : base("Hopper Outside")
        {
            AddVersion("hopper_outside")
                .MapsToJavaBlock<Java.Textures.Block.HopperOutside>();
        }
    }
}

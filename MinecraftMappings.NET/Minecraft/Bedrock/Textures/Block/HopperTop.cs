using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HopperTop : BedrockBlockTexture
    {
        public HopperTop() : base("Hopper Top")
        {
            AddVersion("hopper_top")
                .MapsToJavaBlock<Java.Textures.Block.HopperTop>();
        }
    }
}

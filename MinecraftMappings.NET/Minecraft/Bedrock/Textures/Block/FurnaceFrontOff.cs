using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FurnaceFrontOff : BedrockBlockTexture
    {
        public FurnaceFrontOff() : base("Furnace Front, Off")
        {
            AddVersion("furnace_front_off")
                .MapsToJavaBlock<Java.Textures.Block.FurnaceFront>();
        }
    }
}

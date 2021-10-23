using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FurnaceFrontOn : BedrockBlockTexture
    {
        public FurnaceFrontOn() : base("Furnace Front, On")
        {
            AddVersion("furnace_front_on")
                .MapsToJavaBlock<Java.Textures.Block.FurnaceFrontOn>();
        }
    }
}

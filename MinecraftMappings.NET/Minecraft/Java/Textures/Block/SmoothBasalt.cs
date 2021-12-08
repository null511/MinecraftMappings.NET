using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmoothBasalt : JavaBlockTexture
    {
        public SmoothBasalt() : base("Smooth Basalt")
        {
            AddVersion("smooth_basalt");
                //.WithDefaultModel<Java.Models.Block.SmoothBasalt>()
                //.MapsToBedrockBlock<BedrockBlocks.SmoothBasalt>();
        }
    }
}

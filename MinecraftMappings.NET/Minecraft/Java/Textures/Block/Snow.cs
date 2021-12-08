using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Snow : JavaBlockTexture
    {
        public Snow() : base("Snow")
        {
            AddVersion("snow");
                //.WithDefaultModel<Java.Models.Block.Snow>()
                //.MapsToBedrockBlock<BedrockBlocks.Snow>();
        }
    }
}

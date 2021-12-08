using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Shroomlight : JavaBlockTexture
    {
        public Shroomlight() : base("Shroomlight")
        {
            AddVersion("shroomlight");
                //.WithDefaultModel<Java.Models.Block.Shroomlight>()
                //.MapsToBedrockBlock<BedrockBlocks.Shroomlight>();
        }
    }
}

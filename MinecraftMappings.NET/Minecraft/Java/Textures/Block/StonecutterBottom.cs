using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StonecutterBottom : JavaBlockTexture
    {
        public StonecutterBottom() : base("Stonecutter Bottom")
        {
            AddVersion("stonecutter_bottom")
                .WithDefaultModel<Java.Models.Block.Stonecutter>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}

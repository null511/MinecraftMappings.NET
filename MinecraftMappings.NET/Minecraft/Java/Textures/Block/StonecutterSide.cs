using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StonecutterSide : JavaBlockTexture
    {
        public StonecutterSide() : base("Stonecutter Side")
        {
            AddVersion("stonecutter_side")
                .WithDefaultModel<Java.Models.Block.Stonecutter>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}

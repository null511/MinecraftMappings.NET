using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StonecutterTop : JavaBlockTexture
    {
        public StonecutterTop() : base("Stonecutter Top")
        {
            AddVersion("stonecutter_top")
                .WithDefaultModel<Java.Models.Block.Stonecutter>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}

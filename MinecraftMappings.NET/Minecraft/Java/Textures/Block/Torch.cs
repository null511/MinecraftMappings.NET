using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Torch : JavaBlockTexture
    {
        public Torch() : base("Torch")
        {
            AddVersion("torch")
                .WithDefaultModel<Java.Models.Block.Torch>();
                //.MapsToBedrockBlock<BedrockBlocks.Rail>();
        }
    }
}

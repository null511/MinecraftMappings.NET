using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Dandelion : JavaBlockTexture
    {
        public Dandelion() : base("Dandelion")
        {
            AddVersion("dandelion")
                .WithDefaultModel<Java.Models.Block.Dandelion>();
                //.MapsToBedrockBlock<BedrockBlocks.FlowerDandelion>();
        }
    }
}

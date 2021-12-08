using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Sponge : JavaBlockTexture
    {
        public Sponge() : base("Sponge")
        {
            AddVersion("sponge");
                //.WithDefaultModel<Java.Models.Block.Sponge>()
                //.MapsToBedrockBlock<BedrockBlocks.Sponge>();
        }
    }
}

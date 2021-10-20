using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Lever : JavaBlockTexture
    {
        public Lever() : base("Lever")
        {
            AddVersion("lever")
                .WithDefaultModel<Java.Models.Block.Lever>();
                //.MapsToBedrockBlock<BedrockBlocks.Brick>();
        }
    }
}

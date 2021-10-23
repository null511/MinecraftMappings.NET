using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LoomSide : JavaBlockTexture
    {
        public LoomSide() : base("Loom Side")
        {
            AddVersion("loom_side")
                .WithDefaultModel<Java.Models.Block.Loom>();
                //.MapsToBedrockBlock<BedrockBlocks.LoomSide>();
        }
    }
}

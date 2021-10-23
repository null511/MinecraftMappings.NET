using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LoomBottom : JavaBlockTexture
    {
        public LoomBottom() : base("Loom Bottom")
        {
            AddVersion("loom_bottom")
                .WithDefaultModel<Java.Models.Block.Loom>();
                //.MapsToBedrockBlock<BedrockBlocks.LoomBottom>();
        }
    }
}

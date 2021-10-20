using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CactusBottom : JavaBlockTexture
    {
        public CactusBottom() : base("Cactus, Bottom")
        {
            AddVersion("cactus_bottom")
                .WithDefaultModel<Java.Models.Block.Cactus>();
            //.MapsToBedrockBlock<BedrockBlocks.CactusBottom>();
        }
    }
}

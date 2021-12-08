using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulSand : JavaBlockTexture
    {
        public SoulSand() : base("Soul Sand")
        {
            AddVersion("soul_sand");
                //.WithDefaultModel<Java.Models.Block.SoulSand>()
                //.MapsToBedrockBlock<BedrockBlocks.SoulSand>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulSoil : JavaBlockTexture
    {
        public SoulSoil() : base("Soul Soil")
        {
            AddVersion("soul_soil");
                //.WithDefaultModel<Java.Models.Block.SoulSoil>()
                //.MapsToBedrockBlock<BedrockBlocks.SoulSoil>();
        }
    }
}

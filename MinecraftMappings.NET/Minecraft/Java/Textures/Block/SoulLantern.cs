using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulLantern : JavaBlockTexture
    {
        public SoulLantern() : base("Soul Lantern")
        {
            AddVersion("soul_lantern")
                .WithDefaultModel<Java.Models.Block.SoulLantern>();
                //.MapsToBedrockBlock<BedrockBlocks.SoulLantern>();
        }
    }
}

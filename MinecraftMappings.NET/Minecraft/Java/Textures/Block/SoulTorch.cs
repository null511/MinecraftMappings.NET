using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulTorch : JavaBlockTexture
    {
        public SoulTorch() : base("Soul Torch")
        {
            AddVersion("soul_torch")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.SoulTorch>();
                //.MapsToBedrockBlock<BedrockBlocks.Rail>();
        }
    }
}

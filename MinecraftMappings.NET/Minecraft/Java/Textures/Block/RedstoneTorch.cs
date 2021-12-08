using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneTorch : JavaBlockTexture
    {
        public RedstoneTorch() : base("Redstone Torch, On")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("redstone_torch")
                .WithDefaultModel<Java.Models.Block.RedstoneTorch>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneTorchOn>();
        }
    }
}

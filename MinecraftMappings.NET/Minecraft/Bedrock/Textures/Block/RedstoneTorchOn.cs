using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RedstoneTorchOn : BedrockBlockTexture
    {
        public RedstoneTorchOn() : base("Redstone Torch, On")
        {
            AddVersion("redstone_torch_on")
                .MapsToJavaBlock<Java.Textures.Block.RedstoneTorch>();
        }
    }
}

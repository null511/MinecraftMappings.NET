using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RedstoneTorchOff : BedrockBlockTexture
    {
        public RedstoneTorchOff() : base("Redstone Torch, Off")
        {
            AddVersion("redstone_torch_off")
                .MapsToJavaBlock<Java.Textures.Block.RedstoneTorchOff>();
        }
    }
}

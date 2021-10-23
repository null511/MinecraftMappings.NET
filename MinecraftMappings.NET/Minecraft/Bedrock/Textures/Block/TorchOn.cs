using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class TorchOn : BedrockBlockTexture
    {
        public TorchOn() : base("Torch, On")
        {
            AddVersion("torch_on")
                .MapsToJavaBlock<Java.Textures.Block.Torch>();
        }
    }
}

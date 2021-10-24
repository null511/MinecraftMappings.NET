using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneTorchOff : JavaBlockTexture
    {
        public RedstoneTorchOff() : base("Redstone Torch, Off")
        {
            AddVersion("redstone_torch_off")
                .WithDefaultModel<Java.Models.Block.RedstoneTorchOff>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneTorchOff>();
        }
    }
}

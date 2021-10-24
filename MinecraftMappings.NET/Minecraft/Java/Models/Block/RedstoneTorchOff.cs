using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedstoneTorchOff : JavaBlockModel
    {
        public RedstoneTorchOff() : base("Redstone Torch, Off")
        {
            AddVersion("redstone_torch_off", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_torch")
                .AddTexture("torch", "block/redstone_torch_off");
        }
    }
}

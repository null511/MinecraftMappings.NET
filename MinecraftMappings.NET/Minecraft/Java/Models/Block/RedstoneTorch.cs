using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedstoneTorch : JavaBlockModel
    {
        public RedstoneTorch() : base("Redstone Torch")
        {
            AddVersion("redstone_torch", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_torch")
                .AddTexture("torch", "block/redstone_torch");
        }
    }
}

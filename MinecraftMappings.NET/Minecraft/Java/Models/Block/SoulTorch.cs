using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SoulTorch : JavaBlockModel
    {
        public SoulTorch() : base("Soul Torch")
        {
            AddVersion("soul_torch", "1.16")
                .WithPath("models/block")
                .WithParent("block/template_torch")
                .AddTexture("torch", "block/soul_torch");
        }
    }
}

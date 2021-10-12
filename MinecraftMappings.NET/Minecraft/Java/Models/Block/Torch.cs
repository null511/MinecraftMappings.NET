using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Torch : JavaModelData
    {
        public Torch() : base("Torch")
        {
            AddVersion("torch", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_torch")
                .AddTexture("torch", "block/torch");
        }
    }
}

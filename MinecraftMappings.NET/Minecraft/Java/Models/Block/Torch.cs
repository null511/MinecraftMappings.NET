using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Torch : JavaBlockModel
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

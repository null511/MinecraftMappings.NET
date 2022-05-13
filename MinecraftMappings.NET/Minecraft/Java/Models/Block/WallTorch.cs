using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WallTorch : JavaBlockModel
    {
        public WallTorch() : base("Wall Torch")
        {
            AddVersion("wall_torch", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_torch_wall")
                .AddTexture("torch", "block/torch");
        }
    }
}

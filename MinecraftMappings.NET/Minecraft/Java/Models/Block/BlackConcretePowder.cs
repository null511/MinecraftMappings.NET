using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackConcretePowder : JavaBlockModel
    {
        public BlackConcretePowder() : base("Black Concrete Powder")
        {
            AddVersion("black_concrete_powder", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/black_concrete_powder");
        }
    }
}

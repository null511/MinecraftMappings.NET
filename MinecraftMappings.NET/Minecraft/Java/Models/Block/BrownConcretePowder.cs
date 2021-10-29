using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownConcretePowder : JavaBlockModel
    {
        public BrownConcretePowder() : base("Brown Concrete Powder")
        {
            AddVersion("brown_concrete_powder", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/brown_concrete_powder");
        }
    }
}

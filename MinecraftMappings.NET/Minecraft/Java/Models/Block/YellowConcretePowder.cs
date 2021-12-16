using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowConcretePowder : JavaBlockModel
    {
        public YellowConcretePowder() : base("Yellow Concrete Powder")
        {
            AddVersion("yellow_concrete_powder", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/yellow_concrete_powder");
        }
    }
}

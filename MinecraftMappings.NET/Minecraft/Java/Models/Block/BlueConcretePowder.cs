using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueConcretePowder : JavaBlockModel
    {
        public BlueConcretePowder() : base("Blue Concrete Powder")
        {
            AddVersion("blue_concrete_powder", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/blue_concrete_powder");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteConcretePowder : JavaBlockModel
    {
        public WhiteConcretePowder() : base("White Concrete Powder")
        {
            AddVersion("white_concrete_powder", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/white_concrete_powder");
        }
    }
}

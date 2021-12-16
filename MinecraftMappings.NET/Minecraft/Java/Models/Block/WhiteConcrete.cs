using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteConcrete : JavaBlockModel
    {
        public WhiteConcrete() : base("White Concrete")
        {
            AddVersion("white_concrete", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/white_concrete");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackConcrete : JavaBlockModel
    {
        public BlackConcrete() : base("Black Concrete")
        {
            AddVersion("black_concrete", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/black_concrete");
        }
    }
}

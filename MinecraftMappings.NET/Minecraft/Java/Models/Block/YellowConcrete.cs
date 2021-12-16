using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowConcrete : JavaBlockModel
    {
        public YellowConcrete() : base("Yellow Concrete")
        {
            AddVersion("yellow_concrete", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/yellow_concrete");
        }
    }
}

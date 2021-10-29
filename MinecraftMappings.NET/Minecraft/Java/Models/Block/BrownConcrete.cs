using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownConcrete : JavaBlockModel
    {
        public BrownConcrete() : base("Brown Concrete")
        {
            AddVersion("brown_concrete", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/brown_concrete");
        }
    }
}

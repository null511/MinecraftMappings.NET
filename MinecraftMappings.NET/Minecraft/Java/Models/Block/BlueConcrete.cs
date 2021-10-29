using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueConcrete : JavaBlockModel
    {
        public BlueConcrete() : base("Blue Concrete")
        {
            AddVersion("blue_concrete", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/blue_concrete");
        }
    }
}

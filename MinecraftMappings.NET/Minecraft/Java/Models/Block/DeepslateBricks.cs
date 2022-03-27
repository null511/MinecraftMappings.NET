using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeepslateBricks : JavaBlockModel
    {
        public DeepslateBricks() : base("Deepslate Bricks")
        {
            AddVersion("deepslate_bricks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_bricks");
        }
    }
}

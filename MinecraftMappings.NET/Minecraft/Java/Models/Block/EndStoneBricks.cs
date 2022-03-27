using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EndStoneBricks : JavaBlockModel
    {
        public EndStoneBricks() : base("End Stone Bricks")
        {
            AddVersion("end_stone_bricks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/end_stone_bricks");
        }
    }
}

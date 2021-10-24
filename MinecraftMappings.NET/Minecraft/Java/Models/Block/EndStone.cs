using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EndStone : JavaBlockModel
    {
        public EndStone() : base("End Stone")
        {
            AddVersion("end_stone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/end_stone");
        }
    }
}

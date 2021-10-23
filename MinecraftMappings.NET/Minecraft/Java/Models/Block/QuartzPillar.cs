using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class QuartzPillar : JavaBlockModel
    {
        public QuartzPillar() : base("Quartz Pillar")
        {
            AddVersion("quartz_pillar", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/quartz_pillar_top")
                .AddTexture("side", "block/quartz_pillar");
        }
    }
}

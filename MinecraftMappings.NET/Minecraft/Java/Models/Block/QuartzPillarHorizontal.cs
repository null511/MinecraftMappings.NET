using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class QuartzPillarHorizontal : JavaBlockModel
    {
        public QuartzPillarHorizontal() : base("Quartz Pillar, Horizontal")
        {
            AddVersion("quartz_pillar_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/quartz_pillar_top")
                .AddTexture("side", "block/quartz_pillar");
        }
    }
}

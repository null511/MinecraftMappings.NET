using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowStainedGlass : JavaBlockModel
    {
        public YellowStainedGlass() : base("Yellow Stained Glass")
        {
            AddVersion("yellow_stained_glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/yellow_stained_glass");
        }
    }
}

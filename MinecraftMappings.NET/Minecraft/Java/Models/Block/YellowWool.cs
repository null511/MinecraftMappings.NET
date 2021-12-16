using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowWool : JavaBlockModel
    {
        public YellowWool() : base("Yellow Wool")
        {
            AddVersion("yellow_wool", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/yellow_wool");
        }
    }
}

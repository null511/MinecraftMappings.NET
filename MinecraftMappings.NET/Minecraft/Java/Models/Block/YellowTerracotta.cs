using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowTerracotta : JavaBlockModel
    {
        public YellowTerracotta() : base("Yellow Terracotta")
        {
            AddVersion("yellow_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/yellow_terracotta");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackTerracotta : JavaBlockModel
    {
        public BlackTerracotta() : base("Black Terracotta")
        {
            AddVersion("black_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/black_terracotta");
        }
    }
}

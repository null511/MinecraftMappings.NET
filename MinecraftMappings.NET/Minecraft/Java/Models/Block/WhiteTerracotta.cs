using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteTerracotta : JavaBlockModel
    {
        public WhiteTerracotta() : base("White Terracotta")
        {
            AddVersion("white_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/white_terracotta");
        }
    }
}

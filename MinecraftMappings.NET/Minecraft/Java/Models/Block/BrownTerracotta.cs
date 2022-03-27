using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownTerracotta : JavaBlockModel
    {
        public BrownTerracotta() : base("Brown Terracotta")
        {
            AddVersion("brown_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/brown_terracotta");
        }
    }
}

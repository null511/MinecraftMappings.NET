using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Terracotta : JavaBlockModel
    {
        public Terracotta() : base("Terracotta")
        {
            AddVersion("terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/terracotta");
        }
    }
}

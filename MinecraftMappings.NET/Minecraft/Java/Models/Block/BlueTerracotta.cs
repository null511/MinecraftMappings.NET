using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueTerracotta : JavaBlockModel
    {
        public BlueTerracotta() : base("Blue Terracotta")
        {
            AddVersion("blue_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/blue_terracotta");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Diorite : JavaBlockModel
    {
        public Diorite() : base("Diorite")
        {
            AddVersion("diorite", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/diorite");
        }
    }
}

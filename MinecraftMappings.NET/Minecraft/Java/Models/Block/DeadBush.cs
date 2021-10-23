using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadBush : JavaBlockModel
    {
        public DeadBush() : base("Dead Bush")
        {
            AddVersion("dead_bush", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/dead_bush");
        }
    }
}

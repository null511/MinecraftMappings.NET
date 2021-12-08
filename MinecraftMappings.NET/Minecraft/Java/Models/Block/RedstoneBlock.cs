using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedstoneBlock : JavaBlockModel
    {
        public RedstoneBlock() : base("Redstone Block")
        {
            AddVersion("redstone_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/redstone_block");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DripstoneBlock : JavaBlockModel
    {
        public DripstoneBlock() : base("Dripstone Block")
        {
            AddVersion("dripstone_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dripstone_block");
        }
    }
}

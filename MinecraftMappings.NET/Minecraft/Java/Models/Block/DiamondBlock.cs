using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DiamondBlock : JavaBlockModel
    {
        public DiamondBlock() : base("Diamond Block")
        {
            AddVersion("diamond_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/diamond_block");
        }
    }
}

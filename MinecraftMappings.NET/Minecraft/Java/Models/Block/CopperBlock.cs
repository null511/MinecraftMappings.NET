using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CopperBlock : JavaBlockModel
    {
        public CopperBlock() : base("Copper Block")
        {
            AddVersion("copper_block", "1.17")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/copper_block");
        }
    }
}

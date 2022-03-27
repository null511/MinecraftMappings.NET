using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EmeraldBlock : JavaBlockModel
    {
        public EmeraldBlock() : base("Emerald Block")
        {
            AddVersion("emerald_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/emerald_block");
        }
    }
}

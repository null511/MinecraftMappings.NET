using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AmethystBlock : JavaBlockModel
    {
        public AmethystBlock() : base("Amethyst Block")
        {
            AddVersion("amethyst_block", "1.17")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("cross", "block/amethyst_block");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BuddingAmethyst : JavaBlockModel
    {
        public BuddingAmethyst() : base("Budding Amethyst")
        {
            AddVersion("budding_amethyst", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/budding_amethyst");
        }
    }
}

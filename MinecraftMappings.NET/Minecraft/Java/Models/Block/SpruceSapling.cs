using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceSapling : JavaBlockModel
    {
        public SpruceSapling() : base("Spruce Sapling")
        {
            AddVersion("spruce_sapling", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/spruce_sapling");
        }
    }
}

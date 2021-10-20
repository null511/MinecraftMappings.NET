using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownMushroom : JavaBlockModel
    {
        public BrownMushroom() : base("Brown Mushroom")
        {
            AddVersion("brown_mushroom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/brown_mushroom");
        }
    }
}

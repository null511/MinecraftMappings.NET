using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedMushroom : JavaBlockModel
    {
        public RedMushroom() : base("Red Mushroom")
        {
            AddVersion("red_mushroom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/red_mushroom");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BeeNest : JavaBlockModel
    {
        public BeeNest() : base("Bee Nest")
        {
            AddVersion("bee_nest", "1.15")
                .WithPath("models/block")
                .WithParent("block/orientable_with_bottom")
                .AddTexture("top", "block/bee_nest_top")
                .AddTexture("bottom", "block/bee_nest_bottom")
                .AddTexture("side", "block/bee_nest_side")
                .AddTexture("front", "block/bee_nest_front");
        }
    }
}

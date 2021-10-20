using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BeehiveHoney : JavaBlockModel
    {
        public BeehiveHoney() : base("Beehive, Honey")
        {
            AddVersion("beehive_honey", "1.15")
                .WithPath("models/block")
                .WithParent("block/orientable_with_bottom")
                .AddTexture("top", "block/beehive_end")
                .AddTexture("bottom", "block/beehive_end")
                .AddTexture("side", "block/beehive_side")
                .AddTexture("front", "block/beehive_front_honey");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Smoker : JavaBlockModel
    {
        public Smoker() : base("Smoker")
        {
            AddVersion("smoker", "1.14")
                .WithPath("models/block")
                .WithParent("block/orientable_with_bottom")
                .AddTexture("top", "block/smoker_top")
                .AddTexture("bottom", "block/smoker_bottom")
                .AddTexture("side", "block/smoker_side")
                .AddTexture("front", "block/smoker_front");
        }
    }
}

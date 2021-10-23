using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RailCorner : JavaBlockModel
    {
        public RailCorner() : base("Rail Corner")
        {
            AddVersion("rail_corner", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/rail_curved")
                .AddTexture("rail", "block/rail_corner");
        }
    }
}

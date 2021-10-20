using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Rail : JavaBlockModel
    {
        public Rail() : base("Rail")
        {
            AddVersion("rail", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/rail");
        }
    }
}

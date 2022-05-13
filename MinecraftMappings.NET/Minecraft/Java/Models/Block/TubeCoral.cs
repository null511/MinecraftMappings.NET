using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TubeCoral : JavaBlockModel
    {
        public TubeCoral() : base("Tube Coral")
        {
            AddVersion("tube_coral", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/tube_coral");
        }
    }
}

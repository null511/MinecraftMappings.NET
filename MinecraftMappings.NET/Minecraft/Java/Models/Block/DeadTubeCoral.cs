using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadTubeCoral : JavaBlockModel
    {
        public DeadTubeCoral() : base("Dead Tube Coral")
        {
            AddVersion("dead_tube_coral", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("fan", "block/dead_tube_coral");
        }
    }
}

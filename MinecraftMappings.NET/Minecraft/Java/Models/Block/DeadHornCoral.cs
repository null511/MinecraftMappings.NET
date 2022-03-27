using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadHornCoral : JavaBlockModel
    {
        public DeadHornCoral() : base("Dead Horn Coral")
        {
            AddVersion("dead_horn_coral", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("fan", "block/dead_horn_coral");
        }
    }
}

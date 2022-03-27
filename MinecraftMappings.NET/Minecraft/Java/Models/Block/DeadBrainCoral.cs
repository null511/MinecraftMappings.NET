using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadBrainCoral : JavaBlockModel
    {
        public DeadBrainCoral() : base("Dead Brain Coral")
        {
            AddVersion("dead_brain_coral", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("fan", "block/dead_brain_coral");
        }
    }
}

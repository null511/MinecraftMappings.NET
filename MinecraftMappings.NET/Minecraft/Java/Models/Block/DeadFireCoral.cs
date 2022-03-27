using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadFireCoral : JavaBlockModel
    {
        public DeadFireCoral() : base("Dead Fire Coral")
        {
            AddVersion("dead_fire_coral", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("fan", "block/dead_fire_coral");
        }
    }
}

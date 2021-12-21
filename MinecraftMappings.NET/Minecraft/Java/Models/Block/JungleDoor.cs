using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleDoor : JavaBlockModel
    {
        public JungleDoor() : base("Jungle Door")
        {
            AddVersion("jungle_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/jungle_door_top")
                .AddTexture("bottom", "block/jungle_door_bottom");
        }
    }
}

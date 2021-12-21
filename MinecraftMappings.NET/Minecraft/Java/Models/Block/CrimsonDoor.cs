using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonDoor : JavaBlockModel
    {
        public CrimsonDoor() : base("Crimson Door")
        {
            AddVersion("crimson_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/crimson_door_top")
                .AddTexture("bottom", "block/crimson_door_bottom");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class IronDoor : JavaBlockModel
    {
        public IronDoor() : base("Iron Door")
        {
            AddVersion("iron_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/iron_door_top")
                .AddTexture("bottom", "block/iron_door_bottom");
        }
    }
}

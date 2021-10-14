using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceDoor : JavaBlockModel
    {
        public SpruceDoor() : base("Spruce Door")
        {
            AddVersion("spruce_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/spruce_door_top")
                .AddTexture("bottom", "block/spruce_door_bottom");
        }
    }
}

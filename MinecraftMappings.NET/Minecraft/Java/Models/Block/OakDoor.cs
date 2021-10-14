using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakDoor : JavaBlockModel
    {
        public OakDoor() : base("Oak Door")
        {
            AddVersion("oak_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/oak_door_top")
                .AddTexture("bottom", "block/oak_door_bottom");
        }
    }
}

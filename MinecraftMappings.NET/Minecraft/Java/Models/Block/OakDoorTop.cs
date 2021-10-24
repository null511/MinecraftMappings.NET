using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakDoorTop : JavaBlockModel
    {
        public OakDoorTop() : base("Oak Door, Top")
        {
            AddVersion("oak_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/oak_door_top")
                .AddTexture("bottom", "block/oak_door_bottom");
        }
    }
}

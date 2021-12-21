using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakDoorTop : JavaBlockModel
    {
        public DarkOakDoorTop() : base("Dark Oak Door Top")
        {
            AddVersion("dark_oak_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/dark_oak_door_top")
                .AddTexture("bottom", "block/dark_oak_door_bottom");
        }
    }
}

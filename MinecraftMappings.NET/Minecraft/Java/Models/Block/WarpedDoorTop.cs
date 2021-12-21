using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedDoorTop : JavaBlockModel
    {
        public WarpedDoorTop() : base("Warped Door Top")
        {
            AddVersion("warped_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/warped_door_top")
                .AddTexture("bottom", "block/warped_door_bottom");
        }
    }
}

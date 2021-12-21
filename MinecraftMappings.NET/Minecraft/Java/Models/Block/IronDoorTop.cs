using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class IronDoorTop : JavaBlockModel
    {
        public IronDoorTop() : base("Iron Door Top")
        {
            AddVersion("iron_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/iron_door_top")
                .AddTexture("bottom", "block/iron_door_bottom");
        }
    }
}

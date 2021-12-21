using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleDoorTop : JavaBlockModel
    {
        public JungleDoorTop() : base("Jungle Door Top")
        {
            AddVersion("jungle_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/jungle_door_top")
                .AddTexture("bottom", "block/jungle_door_bottom");
        }
    }
}

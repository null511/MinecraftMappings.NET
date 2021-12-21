using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleDoorBottom : JavaBlockModel
    {
        public JungleDoorBottom() : base("Jungle Door Bottom")
        {
            AddVersion("jungle_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/jungle_door_top")
                .AddTexture("bottom", "block/jungle_door_bottom");
        }
    }
}

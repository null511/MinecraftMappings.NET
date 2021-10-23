using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JackOLantern : JavaBlockModel
    {
        public JackOLantern() : base("Jack O'Lantern")
        {
            AddVersion("jack_o_lantern", "1.2.0")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/pumpkin_top")
                .AddTexture("front", "block/jack_o_lantern")
                .AddTexture("side", "block/pumpkin_side");
        }
    }
}

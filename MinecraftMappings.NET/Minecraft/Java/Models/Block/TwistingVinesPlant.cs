using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TwistingVinesPlant : JavaBlockModel
    {
        public TwistingVinesPlant() : base("Twisting Vines Plant")
        {
            AddVersion("twisting_vines_plant", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/twisting_vines_plant");
        }
    }
}

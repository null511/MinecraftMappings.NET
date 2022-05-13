using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WetSponge : JavaBlockModel
    {
        public WetSponge() : base("Wet Sponge")
        {
            AddVersion("wet_sponge", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/wet_sponge");
        }
    }
}

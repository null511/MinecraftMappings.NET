using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class KelpPlant : JavaBlockModel
    {
        public KelpPlant() : base("Kelp Plant")
        {
            AddVersion("kelp_plant", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/kelp_plant");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteWallSide : JavaBlockModel
    {
        public AndesiteWallSide() : base("Andesite Wall Side")
        {
            AddVersion("andesite_wall_side", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_wall_side")
                .AddTexture("wall", "block/andesite");
        }
    }
}

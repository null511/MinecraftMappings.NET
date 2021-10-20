using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteWallSideTall : JavaBlockModel
    {
        public AndesiteWallSideTall() : base("Andesite Wall Side, Tall")
        {
            AddVersion("andesite_wall_side_tall", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_wall_side_tall")
                .AddTexture("wall", "block/andesite");
        }
    }
}

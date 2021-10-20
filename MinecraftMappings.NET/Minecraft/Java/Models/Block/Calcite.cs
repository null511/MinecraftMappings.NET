using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Calcite : JavaBlockModel
    {
        public Calcite() : base("Calcite")
        {
            AddVersion("calcite", "1.17")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/calcite");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Carrots_Stage0 : JavaBlockModel
    {
        public Carrots_Stage0() : base("Carrots, Stage 0")
        {
            AddVersion("carrots_stage0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/carrots_stage0");
        }
    }
}

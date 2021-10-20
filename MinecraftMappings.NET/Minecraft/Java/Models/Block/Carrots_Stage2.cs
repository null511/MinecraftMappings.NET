using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Carrots_Stage2 : JavaBlockModel
    {
        public Carrots_Stage2() : base("Carrots, Stage 2")
        {
            AddVersion("carrots_stage2", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/carrots_stage2");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Carrots_Stage1 : JavaBlockModel
    {
        public Carrots_Stage1() : base("Carrots, Stage 1")
        {
            AddVersion("carrots_stage1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/carrots_stage1");
        }
    }
}

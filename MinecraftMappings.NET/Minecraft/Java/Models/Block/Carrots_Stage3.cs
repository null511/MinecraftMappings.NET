using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Carrots_Stage3 : JavaBlockModel
    {
        public Carrots_Stage3() : base("Carrots, Stage 3")
        {
            AddVersion("carrots_stage3", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/carrots_stage3");
        }
    }
}

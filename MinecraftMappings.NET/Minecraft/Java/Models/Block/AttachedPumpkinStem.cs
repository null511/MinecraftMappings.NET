using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AttachedPumpkinStem : JavaBlockModel
    {
        public AttachedPumpkinStem() : base("Attached Pumpkin Stem")
        {
            AddVersion("attached_pumpkin_stem", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_fruit")
                .AddTexture("stem", "block/pumpkin_stem")
                .AddTexture("upperstem", "block/attached_pumpkin_stem");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AttachedMelonStem : JavaBlockModel
    {
        public AttachedMelonStem() : base("Attached Melon Stem")
        {
            AddVersion("attached_melon_stem", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_fruit")
                .AddTexture("stem", "block/melon_stem")
                .AddTexture("upperstem", "block/attached_melon_stem");
        }
    }
}

using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChorusFlower_Dead : JavaBlockModel
    {
        public ChorusFlower_Dead() : base("Chorus Flower, Dead")
        {
            AddVersion("chorus_flower_dead", "1.16")
                .WithPath("models/block")
                .WithParent("block/template_chorus_flower")
                .AddTexture("cross", "block/chorus_flower_dead");
        }
    }
}

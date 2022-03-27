using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChorusFlower : JavaBlockModel
    {
        public ChorusFlower() : base("Chorus Flower")
        {
            AddVersion("chorus_flower", "1.16")
                .WithPath("models/block")
                .WithParent("block/template_chorus_flower")
                .AddTexture("cross", "block/chorus_flower");
        }
    }
}

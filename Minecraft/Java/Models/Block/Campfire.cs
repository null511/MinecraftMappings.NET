using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Campfire : JavaModelData
    {
        public Campfire() : base("Campfire")
        {
            AddVersion("campfire", "1.14")
                .WithPath("models/block")
                .WithParent("block/template_campfire")
                .AddTexture("fire", "block/campfire_fire")
                .AddTexture("lit_log", "block/campfire_log_lit");
        }
    }
}

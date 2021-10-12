using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SugarCane : JavaModelData
    {
        public SugarCane() : base("Sugar Cane")
        {
            AddVersion("sugar_cane", "1.2")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/sugar_cane");
        }
    }
}

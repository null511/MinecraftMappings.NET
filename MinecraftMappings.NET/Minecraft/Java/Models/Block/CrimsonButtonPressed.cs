using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonButtonPressed : JavaBlockModel
    {
        public CrimsonButtonPressed() : base("Crimson Button, Pressed")
        {
            AddVersion("crimson_button_pressed", "1.16")
                .WithPath("models/block")
                .WithParent("block/button_pressed")
                .AddTexture("texture", "block/crimson_planks");
        }
    }
}

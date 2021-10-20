using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaButtonPressed : JavaBlockModel
    {
        public AcaciaButtonPressed() : base("Acacia Button, Pressed")
        {
            AddVersion("acacia_button_pressed", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/button_pressed")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}

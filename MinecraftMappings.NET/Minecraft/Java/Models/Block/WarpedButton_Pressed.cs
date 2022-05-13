using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedButton_Pressed : JavaBlockModel
    {
        public WarpedButton_Pressed() : base("Warped Button, Pressed")
        {
            AddVersion("warped_button_pressed", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/button_pressed")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}

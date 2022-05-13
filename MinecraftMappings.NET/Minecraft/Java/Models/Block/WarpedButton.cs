using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedButton : JavaBlockModel
    {
        public WarpedButton() : base("Warped Button")
        {
            AddVersion("warped_button", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/button")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}

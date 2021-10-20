using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Banner : JavaBlockModel
    {
        public Banner() : base("Banner")
        {
            AddVersion("banner", "1.0.0")
                .WithPath("models/block");
        }
    }
}

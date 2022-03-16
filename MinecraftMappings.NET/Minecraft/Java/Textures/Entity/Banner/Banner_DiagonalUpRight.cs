using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_DiagonalUpRight : JavaEntityTexture
    {
        public Banner_DiagonalUpRight() : base("Banner, Diagonal-Up-Right")
        {
            AddVersion("diagonal_up_right")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_DiagonalUpRight>();
        }
    }
}

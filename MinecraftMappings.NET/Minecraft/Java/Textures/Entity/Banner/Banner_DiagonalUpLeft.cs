using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_DiagonalUpLeft : JavaEntityTexture
    {
        public Banner_DiagonalUpLeft() : base("Banner, Diagonal-Up-Left")
        {
            AddVersion("diagonal_up_left")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_DiagonalUpLeft>();
        }
    }
}

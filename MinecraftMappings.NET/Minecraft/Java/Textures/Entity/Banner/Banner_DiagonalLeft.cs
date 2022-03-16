using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_DiagonalLeft : JavaEntityTexture
    {
        public Banner_DiagonalLeft() : base("Banner, Diagonal-Left")
        {
            AddVersion("diagonal_left")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_DiagonalLeft>();
        }
    }
}

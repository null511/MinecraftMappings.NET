using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_DiagonalRight : JavaEntityTexture
    {
        public Banner_DiagonalRight() : base("Banner, Diagonal-Right")
        {
            AddVersion("diagonal_right")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_DiagonalRight>();
        }
    }
}

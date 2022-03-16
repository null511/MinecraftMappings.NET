using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Bricks : JavaEntityTexture
    {
        public Banner_Bricks() : base("Banner, Bricks")
        {
            AddVersion("bricks")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Bricks>();
        }
    }
}

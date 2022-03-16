using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Gradient : JavaEntityTexture
    {
        public Banner_Gradient() : base("Banner, Gradient")
        {
            AddVersion("gradient")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Gradient>();
        }
    }
}

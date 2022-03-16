using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_GradientUp : JavaEntityTexture
    {
        public Banner_GradientUp() : base("Banner, Gradient Up")
        {
            AddVersion("gradient_up")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_GradientUp>();
        }
    }
}

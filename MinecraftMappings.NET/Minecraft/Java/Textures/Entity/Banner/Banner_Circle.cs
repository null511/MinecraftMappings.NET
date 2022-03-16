using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Circle : JavaEntityTexture
    {
        public Banner_Circle() : base("Banner, Circle")
        {
            AddVersion("circle")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Circle>();
        }
    }
}

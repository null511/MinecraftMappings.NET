using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Creeper : JavaEntityTexture
    {
        public Banner_Creeper() : base("Banner, Creeper")
        {
            AddVersion("creeper")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Creeper>();
        }
    }
}

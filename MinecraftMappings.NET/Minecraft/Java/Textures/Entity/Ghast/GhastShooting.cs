using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Ghast
{
    public class GhastShooting : JavaEntityTexture
    {
        public GhastShooting() : base("Ghast Shooting")
        {
            AddVersion("ghast_shooting")
                .WithPath("entity/ghast")
                .WithDefaultModel<Java.Models.Entity.Ghast>();
                //.MapsToBedrockEntity<BedrockEntities.GhastShooting>();
        }
    }
}

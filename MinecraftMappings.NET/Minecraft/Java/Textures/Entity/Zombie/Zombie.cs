using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Zombie
{
    public class Zombie : JavaEntityTexture
    {
        public Zombie() : base("Zombie")
        {
            AddVersion("zombie")
                .WithPath("entity/zombie")
                .WithDefaultModel<Java.Models.Entity.Zombie>();
                //.MapsToBedrockEntity<BedrockEntities.Zombie>();
        }
    }
}

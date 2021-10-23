using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Zombie
{
    public class Husk : JavaEntityTexture
    {
        public Husk() : base("Husk")
        {
            AddVersion("husk")
                .WithPath("entity/zombie")
                .WithDefaultModel<Java.Models.Entity.Zombie>();
                //.MapsToBedrockEntity<BedrockEntities.Zombie>();
        }
    }
}

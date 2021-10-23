using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Zombie
{
    public class Drowned : JavaEntityTexture
    {
        public Drowned() : base("Drowned")
        {
            AddVersion("drowned")
                .WithPath("entity/zombie")
                .WithDefaultModel<Java.Models.Entity.Zombie>();
                //.MapsToBedrockEntity<BedrockEntities.Drowned>();
        }
    }
}

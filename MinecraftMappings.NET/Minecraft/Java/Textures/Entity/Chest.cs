using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Chest : JavaEntityTexture
    {
        public Chest() : base("Chest")
        {
            AddVersion("chest")
                .WithDefaultModel<Java.Models.Entity.Chest>();
                //.MapsToBedrockEntity<BedrockEntities.Bee>();
        }
    }
}

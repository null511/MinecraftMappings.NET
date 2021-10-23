using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Creeper
{
    public class Creeper : JavaEntityTexture
    {
        public Creeper() : base("Creeper")
        {
            AddVersion("creeper")
                .WithPath("entity/creeper")
                .WithDefaultModel<Java.Models.Entity.Creeper>();
                //.MapsToBedrockEntity<BedrockEntities.Creeper>();
        }
    }
}

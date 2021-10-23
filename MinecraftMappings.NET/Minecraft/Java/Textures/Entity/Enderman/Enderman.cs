using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Enderman
{
    public class Enderman : JavaEntityTexture
    {
        public Enderman() : base("Enderman")
        {
            AddVersion("enderman")
                .WithPath("entity/enderman")
                .WithDefaultModel<Java.Models.Entity.Enderman>();
                //.MapsToBedrockEntity<BedrockEntities.Enderman>();
        }
    }
}

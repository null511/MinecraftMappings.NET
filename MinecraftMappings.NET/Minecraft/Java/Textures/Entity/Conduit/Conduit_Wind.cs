using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_Wind : JavaEntityTexture
    {
        public Conduit_Wind() : base("Conduit, Wind")
        {
            AddVersion("wind")
                .WithPath("entity/conduit")
                .WithDefaultModel<Java.Models.Entity.Conduit>();
                //.MapsToBedrockEntity<BedrockEntities.ConduitWind>();
        }
    }
}

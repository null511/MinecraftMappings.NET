using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Warden
{
    public class Warden_PulsatingSpots2 : JavaEntityTexture
    {
        public Warden_PulsatingSpots2() : base("Warden, Pulsating Spots 2")
        {
            AddVersion("warden_pulsating_spots_2")
                .WithPath("entity/warden")
                .WithDefaultModel<Java.Models.Entity.Warden>();
                //.MapsToBedrockEntity<BedrockEntities.Warden>();
        }
    }
}

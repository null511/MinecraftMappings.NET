using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Warden
{
    public class Warden_PulsatingSpots1 : JavaEntityTexture
    {
        public Warden_PulsatingSpots1() : base("Warden, Pulsating Spots 1")
        {
            AddVersion("warden_pulsating_spots_1")
                .WithPath("entity/warden")
                .WithDefaultModel<Java.Models.Entity.Warden>();
                //.MapsToBedrockEntity<BedrockEntities.Warden>();
        }
    }
}

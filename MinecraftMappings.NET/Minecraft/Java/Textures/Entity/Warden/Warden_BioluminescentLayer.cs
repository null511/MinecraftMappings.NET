using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Warden
{
    public class Warden_BioluminescentLayer : JavaEntityTexture
    {
        public Warden_BioluminescentLayer() : base("Warden, Bioluminescent Layer")
        {
            AddVersion("warden_bioluminescent_layer")
                .WithPath("entity/warden")
                .WithDefaultModel<Java.Models.Entity.Warden>();
                //.MapsToBedrockEntity<BedrockEntities.Warden>();
        }
    }
}

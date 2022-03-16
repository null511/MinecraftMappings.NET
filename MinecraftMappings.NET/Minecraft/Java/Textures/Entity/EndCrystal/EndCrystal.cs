using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.EndCrystal
{
    public class EndCrystal : JavaEntityTexture
    {
        public EndCrystal() : base("End Crystal")
        {
            AddVersion("end_crystal")
                .WithPath("entity/end_crystal")
                .WithDefaultModel<Java.Models.Entity.EndCrystal>();
                //.MapsToBedrockEntity<BedrockEntities.EndCrystal>();
        }
    }
}

using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Frog
{
    public class TemperateFrog : JavaEntityTexture
    {
        public TemperateFrog() : base("Frog, Temperate")
        {
            AddVersion("temperate_frog")
                .WithPath("entity/frog")
                .WithDefaultModel<Java.Models.Entity.Frog>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Black>();
        }
    }
}

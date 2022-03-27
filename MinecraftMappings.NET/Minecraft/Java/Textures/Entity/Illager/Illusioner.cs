using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Illusioner : JavaEntityTexture
    {
        public Illusioner() : base("Illusioner")
        {
            AddVersion("illusioner")
                .WithPath("entity/illager");
                //.WithDefaultModel<Java.Models.Entity.Illusioner>();
                //.MapsToBedrockEntity<BedrockEntities.Illusioner>();
        }
    }
}

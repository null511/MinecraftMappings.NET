using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Vex : JavaEntityTexture
    {
        public Vex() : base("Vex")
        {
            AddVersion("vex")
                .WithPath("entity/illager");
                //.WithDefaultModel<Java.Models.Entity.Vex>();
                //.MapsToBedrockEntity<BedrockEntities.Vex>();
        }
    }
}

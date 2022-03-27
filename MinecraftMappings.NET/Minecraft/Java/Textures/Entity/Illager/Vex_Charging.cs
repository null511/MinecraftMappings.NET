using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Vex_Charging : JavaEntityTexture
    {
        public Vex_Charging() : base("Vex, Charging")
        {
            AddVersion("vex_charging")
                .WithPath("entity/illager");
                //.WithDefaultModel<Java.Models.Entity.Vex_Charging>();
                //.MapsToBedrockEntity<BedrockEntities.Vex_Charging>();
        }
    }
}

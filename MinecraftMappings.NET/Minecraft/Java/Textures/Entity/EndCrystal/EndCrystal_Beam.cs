using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.EndCrystal
{
    public class EndCrystal_Beam : JavaEntityTexture
    {
        public EndCrystal_Beam() : base("End Crystal Beam")
        {
            AddVersion("end_crystal_beam")
                .WithPath("entity/end_crystal");
                //.WithDefaultModel<Java.Models.Entity.EndCrystal>();
                //.MapsToBedrockEntity<BedrockEntities.EndCrystal_Beam>();
        }
    }
}

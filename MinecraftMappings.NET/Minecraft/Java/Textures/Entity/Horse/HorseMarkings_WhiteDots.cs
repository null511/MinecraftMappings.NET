using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class HorseMarkings_WhiteDots : JavaEntityTexture
    {
        public HorseMarkings_WhiteDots() : base("Horse Markings, White Dots")
        {
            AddVersion("horse_markings_whitedots")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.HorseMarkings_WhiteDots>();
        }
    }
}

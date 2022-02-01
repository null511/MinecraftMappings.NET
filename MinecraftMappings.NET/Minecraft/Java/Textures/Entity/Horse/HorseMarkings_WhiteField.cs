using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class HorseMarkings_WhiteField : JavaEntityTexture
    {
        public HorseMarkings_WhiteField() : base("Horse Markings, White Field")
        {
            AddVersion("horse_markings_whitefield")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.HorseMarkings_WhiteField>();
        }
    }
}

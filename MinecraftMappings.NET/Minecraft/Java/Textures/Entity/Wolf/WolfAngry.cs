using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wolf
{
    public class WolfAngry : JavaEntityTexture
    {
        public WolfAngry() : base("Wolf, Angry")
        {
            AddVersion("wolf_angry")
                .WithPath("entity/wolf")
                .WithDefaultModel<Java.Models.Entity.Wolf>();
                //.MapsToBedrockEntity<BedrockEntities.WolfAngry>();
        }
    }
}

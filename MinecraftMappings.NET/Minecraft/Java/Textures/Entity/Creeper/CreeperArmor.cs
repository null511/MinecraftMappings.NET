using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Creeper
{
    public class CreeperArmor : JavaEntityTexture
    {
        public CreeperArmor() : base("Creeper Armor")
        {
            AddVersion("creeper_armor")
                .WithPath("entity/creeper")
                .WithBaseLayer<Creeper>()
                .WithDefaultModel<Java.Models.Entity.Creeper>();
                //.MapsToBedrockEntity<BedrockEntities.CreeperArmor>();
        }
    }
}

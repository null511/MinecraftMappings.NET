using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wither
{
    public class WitherArmor : JavaEntityTexture
    {
        public WitherArmor() : base("Wither Armor")
        {
            AddVersion("wither_armor")
                .WithBaseLayer<Wither>()
                .WithDefaultModel<Java.Models.Entity.Wither>();
                //.MapsToBedrockEntity<BedrockEntities.WitherArmor>();
        }
    }
}

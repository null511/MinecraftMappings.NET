using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class ChainmailArmor_Layer2 : JavaEntityTexture
    {
        public ChainmailArmor_Layer2() : base("Chainmail Armor, Layer 2")
        {
            AddVersion("chainmail_layer_2")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer2>();
                //.MapsToBedrockEntity<BedrockEntities.ChainmailArmor_Layer2>();
        }
    }
}
